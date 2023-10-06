using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using HtmlAgilityPack;
using TeamLong.Citrix.Director.Handlers;
using TeamLong.Citrix.Director.Results;
using TeamLong.Citrix.Exceptions;

namespace TeamLong.Citrix.Director.Implements;

public sealed class DirectorProxy : IDirectorProxy
{
    private readonly IDirectorSite _site;
    private readonly Uri _uri;
    private HttpClient _client;
    private CookieContainer _cookieContainer = new();
    private InitializationDataResult _initializationData;

    internal DirectorProxy(IDirectorSite site)
    {
        var logOnUrl = site.LogOnUrl;
        var success = Uri.TryCreate(logOnUrl, UriKind.Absolute, out _uri);
        if (success == false)
            throw new FormatException("无效的登录地址。");
        _site = site;
    }

    public IEnumerable<Cookie> Cookies => _cookieContainer.GetAllCookies();

    public Guid Id => _site.Id;

    public string SiteId
    {
        get
        {
            // 如果初始化数据为空，则自动连接，获取初始化数据
            if (_initializationData == null)
                Connect().Wait();
            return _initializationData?.GetInitializationDataResult.Sites.FirstOrDefault()?.Id;
        }
    }

    /// <summary>
    ///     最后请求时间
    /// </summary>
    public DateTime? LastRequestTime { get; private set; }

    /// <summary>
    ///     最后请求的状态码
    /// </summary>
    public string? LastResponseStatus { get; private set; }

    public async Task Connect()
    {
        // 获取登录页面参数
        await GetLogOnPageParamsAsync();
        // 执行登录
        await LogOnAsync();
        // 检查登录结果
        if (IsLogOnSuccess() == false)
            throw new DirectorLogOnException("登录失败，请检查连接配置是否正确。");
        // 获取初始化数据
        _initializationData = await GetInitializationDataAsync();
    }

    /// <summary>
    ///     判断是否登录成功
    /// </summary>
    /// <returns></returns>
    private bool IsLogOnSuccess()
    {
        return Cookies.Any(p => p.Name == "XSRF_KEY");
    }

    /// <summary>
    ///     设置最后的运行状态
    /// </summary>
    /// <param name="status"></param>
    private void SetLastRunningStatus(HttpStatusCode status)
    {
        LastRequestTime = DateTime.Now;
        LastResponseStatus = Enum.GetName(typeof(HttpStatusCode), status);
    }

    public DirectorProxy Init()
    {
        // 初始化Cookie容器
        _cookieContainer = new CookieContainer();
        // 构建DirectorClient
        var handler = new HttpDelegateHandler
        {
            InnerHandler = new HttpClientHandler { CookieContainer = _cookieContainer },
            CookieContainer = _cookieContainer,
            SetLastRunningStatusAction = SetLastRunningStatus,
            ConnectAction = Connect
        };
        _client = new HttpClient(handler) { BaseAddress = _uri };
        return this;
    }

    #region Director API

    /// <summary>
    ///     获取页面参数
    /// </summary>
    /// <returns></returns>
    public async Task<LogOnPageParams> GetLogOnPageParamsAsync()
    {
        const string url = "LogOn.aspx";
        var resp = await _client.GetAsync(url);
        var content = await resp.Content.ReadAsStringAsync();
        var doc = new HtmlDocument();
        doc.LoadHtml(content);

        var result = new LogOnPageParams
        {
            VIEWSTATE = doc.GetElementbyId("__VIEWSTATE").GetAttributeValue("value", null),
            VIEWSTATEGENERATOR = doc.GetElementbyId("__VIEWSTATEGENERATOR").GetAttributeValue("value", null),
            EVENTVALIDATION = doc.GetElementbyId("__EVENTVALIDATION").GetAttributeValue("value", null),
            Submit = doc.GetElementbyId("Submit").GetAttributeValue("value", null)
        };

        return result;
    }

    /// <summary>
    ///     登录
    /// </summary>
    public async Task<HttpResponseMessage> LogOnAsync()
    {
        var pageParams = await GetLogOnPageParamsAsync();
        var userName = _site.UserName;
        var password = _site.Password;
        var domain = _site.Domain;

        // ?cc=true必须加，否则无法登录
        const string url = "LogOn.aspx?cc=true";
        var content = new FormUrlEncodedContent(new[]
        {
            new KeyValuePair<string, string>("__VIEWSTATE", pageParams.VIEWSTATE),
            new KeyValuePair<string, string>("__VIEWSTATEGENERATOR", pageParams.VIEWSTATEGENERATOR),
            new KeyValuePair<string, string>("__EVENTVALIDATION", pageParams.EVENTVALIDATION),
            new KeyValuePair<string, string>("UserName", userName),
            new KeyValuePair<string, string>("Password", password),
            new KeyValuePair<string, string>("Domain", domain),
            new KeyValuePair<string, string>("Submit", "%E7%99%BB%E5%BD%95")
        });

        var resp = await _client.PostAsync(url, content);
        return resp;
    }

    public async Task<InitializationDataResult> GetInitializationDataAsync()
    {
        const string url = "service.svc/web/GetInitializationData";
        var res = await _client.PostAsync(url, null);
        var data = await res.Content.ReadFromJsonAsync<InitializationDataResult>();
        return data;
    }

    public async Task<FailedVDIMachinesDetailsByTypeResult> GetFailedVDIMachinesDetailsByTypeAsync(
        string failureType = "Any")
    {
        const string url = "service.svc/web/GetFailedVDIMachinesDetailsByType";
        var resp = await _client.PostAsJsonAsync(url, new
        {
            failureType = failureType ?? "Any",
            intervalInMin = 1,
            siteId = SiteId
        });

        var content = await resp.Content.ReadFromJsonAsync<FailedVDIMachinesDetailsByTypeResult>();
        return content;
    }

    public async Task<FailedRDSMachinesDetailsByTypeResult> GetFailedRDSMachinesDetailsByTypeAsync(
        string failureType = "Any")
    {
        const string url = "service.svc/web/GetFailedRDSMachinesDetailsByType";
        var resp = await _client.PostAsJsonAsync(url, new
        {
            failureType = failureType ?? "Any",
            intervalInMin = 1,
            siteId = SiteId
        });

        var content = await resp.Content.ReadFromJsonAsync<FailedRDSMachinesDetailsByTypeResult>();
        return content;
    }

    public async Task<AverageLogonDurationDataResult> GetAverageLogonDurationDataAsync()
    {
        const string url = "service.svc/web/GetAverageLogonDurationData";
        var resp = await _client.PostAsJsonAsync(url, new
        {
            intervalInMin = 1,
            siteId = SiteId
        });
        var content = await resp.Content.ReadFromJsonAsync<AverageLogonDurationDataResult>();
        return content;
    }

    public async Task<FailedVDIMachinesDataResult> GetFailedVDIMachinesDataAsync()
    {
        const string url = "service.svc/web/GetFailedVDIMachinesData";
        var resp = await _client.PostAsJsonAsync(url, new { siteId = SiteId });
        var res = await resp.Content.ReadFromJsonAsync<FailedVDIMachinesDataResult>();
        return res;
    }

    public async Task<FailedRDSMachinesDataResult> GetFailedRDSMachinesDataAsync()
    {
        const string url = "service.svc/web/GetFailedRDSMachinesData";
        var resp = await _client.PostAsJsonAsync(url, new { siteId = SiteId });
        var res = await resp.Content.ReadFromJsonAsync<FailedRDSMachinesDataResult>();
        return res;
    }

    public async Task<SiteInfrastructureDataResult> GetSiteInfrastructureDetailsAsync()
    {
        const string url = "service.svc/web/GetSiteInfrastructureData";
        var resp = await _client.PostAsJsonAsync(url, new { siteId = SiteId });
        var res = await resp.Content.ReadFromJsonAsync<SiteInfrastructureDataResult>();
        return res;
    }

    public async Task<ConnectionFailuresDataResult> GetConnectionFailuresDataAsync()
    {
        const string url = "service.svc/web/GetConnectionFailuresData";
        var resp = await _client.PostAsJsonAsync(url, new { siteId = SiteId });
        var res = await resp.Content.ReadFromJsonAsync<ConnectionFailuresDataResult>();
        return res;
    }

    #endregion
}