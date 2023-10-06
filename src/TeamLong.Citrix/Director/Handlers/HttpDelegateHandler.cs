using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using TeamLong.Citrix.Director.Results;

namespace TeamLong.Citrix.Director.Handlers;

public class HttpDelegateHandler : DelegatingHandler
{
    internal Action<HttpStatusCode> SetLastRunningStatusAction { get; set; }
    internal CookieContainer CookieContainer { get; set; }
    internal Func<Task> ConnectAction { get; set; }

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
        CancellationToken cancellationToken)
    {
        retry:

        #region 发送前处理

        var cookies = CookieContainer.GetAllCookies();
        // 获取XSRF_KEY
        var xsrfKey = cookies.FirstOrDefault(p => p.Name == "XSRF_KEY")?.Value;
        if (string.IsNullOrWhiteSpace(xsrfKey) == false)
            // 附加到请求头中
            request.Headers.Add("X-Xsrf-Token", xsrfKey);

        #endregion

        var resp = await base.SendAsync(request, cancellationToken);
        // 记录运行状态
        SetLastRunningStatusAction(resp.StatusCode);

        #region 发送后处理

        if (resp.IsSuccessStatusCode == false)
        {
            if (resp.StatusCode == HttpStatusCode.InternalServerError)
            {
                // 处理凭据过期异常
                var content = await resp.Content.ReadFromJsonAsync<DirectorErrorResult>();
                if (content != null && content.Error.ErrorCode == 101)
                    // 使用排它锁尝试登录操作
                    lock (this)
                    {
                        // 重新登录，如果登录失败，会抛异常
                        ConnectAction().Wait();
                        goto retry;
                    }

                // 未登陆
                throw new Exception("服务器内部错误。");
            }

            if (resp.StatusCode == HttpStatusCode.Unauthorized)
                // 一般为未传入SiteId或传入了错误的SiteId。传错参数也会出发该异常。
            {
                throw new UnauthorizedAccessException("未授权访问。请检查登录账号对该Site是否有访问权限。");
            }
        }

        #endregion

        return resp;
    }
}