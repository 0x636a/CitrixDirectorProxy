using TeamLong.Citrix.Director.Implements;

namespace TeamLong.Citrix.Director;

public class DirectorProxyBuilder
{
    private readonly DirectorProxy _proxy;

    public DirectorProxyBuilder(IDirectorSite site)
    {
        _proxy = new DirectorProxy(site);
    }

    public IDirectorProxy Build()
    {
        _proxy.Init();
        return _proxy;
    }
}