using System;
using System.Collections.Generic;

namespace TeamLong.Citrix.Director;

public interface IProxyContainer
{
    /// <summary>
    ///     获取所有代理
    /// </summary>
    /// <returns></returns>
    IEnumerable<IDirectorProxy> Get(params Guid[] ids);

    /// <summary>
    ///     获取指定代理
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    IDirectorProxy Get(Guid id);

    /// <summary>
    ///     获取或创建一个代理
    /// </summary>
    /// <param name="site"></param>
    /// <returns></returns>
    IDirectorProxy GetOrCreate(IDirectorSite site);

    /// <summary>
    ///     批量创建代理
    /// </summary>
    /// <param name="sites"></param>
    /// <returns></returns>
    IEnumerable<IDirectorProxy> Create(params IDirectorSite[] sites);

    /// <summary>
    ///     批量创建代理
    /// </summary>
    /// <param name="sites"></param>
    /// <returns></returns>
    IEnumerable<IDirectorProxy> Create(IEnumerable<IDirectorSite> sites);

    /// <summary>
    ///     删除一个代理
    /// </summary>
    /// <param name="id"></param>
    void Delete(Guid id);
}