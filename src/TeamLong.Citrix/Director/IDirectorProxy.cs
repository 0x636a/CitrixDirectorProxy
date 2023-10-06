using System;
using System.Threading.Tasks;
using TeamLong.Citrix.Director.Results;

namespace TeamLong.Citrix.Director;

public interface IDirectorProxy
{
    Guid Id { get; }

    /// <summary>
    ///     当前Director的站点ID
    /// </summary>
    string SiteId { get; }

    /// <summary>
    ///     最后请求时间
    /// </summary>
    DateTime? LastRequestTime { get; }

    /// <summary>
    ///     最后请求结果的状态码
    /// </summary>
    string? LastResponseStatus { get; }

    /// <summary>
    ///     测试Director连接
    /// </summary>
    /// <exception cref="DirectorLogOnException">登录失败</exception>
    Task Connect();

    /// <summary>
    ///     获取故障的多会话操作系统的详细信息
    /// </summary>
    /// <returns></returns>
    Task<FailedRDSMachinesDetailsByTypeResult> GetFailedRDSMachinesDetailsByTypeAsync(
        string failureType = "Any");

    /// <summary>
    ///     获取故障的单会话操作系统的详细信息
    /// </summary>
    /// <returns></returns>
    Task<FailedVDIMachinesDetailsByTypeResult> GetFailedVDIMachinesDetailsByTypeAsync(
        string failureType = "Any");

    /// <summary>
    ///     获取初始化数据
    /// </summary>
    /// <returns></returns>
    Task<InitializationDataResult> GetInitializationDataAsync();

    Task<AverageLogonDurationDataResult> GetAverageLogonDurationDataAsync();
    Task<FailedVDIMachinesDataResult> GetFailedVDIMachinesDataAsync();
    Task<FailedRDSMachinesDataResult> GetFailedRDSMachinesDataAsync();
    Task<SiteInfrastructureDataResult> GetSiteInfrastructureDetailsAsync();
    Task<ConnectionFailuresDataResult> GetConnectionFailuresDataAsync();
}