using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace TeamLong.Citrix.Director.Implements;

public class ProxyContainer : IProxyContainer
{
    private readonly ConcurrentDictionary<Guid, IDirectorProxy> _container = new();

    /// <summary>
    ///     获取容器中所有代理
    /// </summary>
    /// <returns></returns>
    public IEnumerable<IDirectorProxy> Get(params Guid[] ids)
    {
        return ids.Length == 0
            ? _container.Select(p => p.Value)
            : _container.Where(p => ids.Contains(p.Key)).Select(p => p.Value);
    }

    /// <summary>
    ///     获取指定的代理
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public IDirectorProxy Get(Guid id)
    {
        return _container.ContainsKey(id) ? _container[id] : null;
    }

    /// <summary>
    ///     获取或创建代理
    /// </summary>
    /// <param name="site"></param>
    /// <returns></returns>
    public IDirectorProxy GetOrCreate(IDirectorSite site)
    {
        var proxy = Get(site.Id);
        if (proxy != null) return proxy;
        proxy = new DirectorProxyBuilder(site).Build();
        Add(proxy);
        return proxy;
    }

    /// <summary>
    ///     批量创建代理
    /// </summary>
    /// <param name="sites"></param>
    /// <returns></returns>
    public IEnumerable<IDirectorProxy> Create(params IDirectorSite[] sites) // 使用ToList()使表达式树立即生效
    {
    return sites.Select(GetOrCreate).ToList();
    }

    /// <summary>
    ///     批量创建代理
    /// </summary>
    /// <param name="sites"></param>
    /// <returns></returns>
    public IEnumerable<IDirectorProxy> Create(IEnumerable<IDirectorSite> sites) // 使用ToList()使表达式树立即生效
    {
    return sites.Select(GetOrCreate).ToList();
    }

    public void Delete(Guid id)
    {
        _container.Remove(id, out _);
    }

    private void Add(IDirectorProxy proxy)
    {
        _container.TryAdd(proxy.Id, proxy);
    }
}