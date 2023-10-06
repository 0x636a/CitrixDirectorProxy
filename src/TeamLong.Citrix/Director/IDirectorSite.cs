using System;

namespace TeamLong.Citrix.Director;

/// <summary>
///     Director站点连接配置
/// </summary>
public interface IDirectorSite
{
    /// <summary>
    ///     业务ID，在Container中通过该字段定位代理
    /// </summary>
    Guid Id { get; set; }

    /// <summary>
    ///     Director登录Url
    /// </summary>
    string LogOnUrl { get; set; }

    /// <summary>
    ///     Director登录用户名
    /// </summary>
    string UserName { get; set; }

    /// <summary>
    ///     Director登录密码
    /// </summary>
    string Password { get; set; }

    /// <summary>
    ///     Director登录域名
    /// </summary>
    string Domain { get; set; }
}