using Microsoft.Extensions.DependencyInjection;
using TeamLong.Citrix.Director;
using TeamLong.Citrix.Director.Implements;

namespace TeamLong.Citrix;

public static class ServiceExtensions
{
    public static IServiceCollection AddDirectorServices(this IServiceCollection services)
    {
        services.AddSingleton<IProxyContainer, ProxyContainer>();
        return services;
    }
}