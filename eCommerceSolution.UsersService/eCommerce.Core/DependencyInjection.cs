using eCommerce.Core.ServiceContract;
using eCommerce.Core.Services;
using Microsoft.Extensions.DependencyInjection;
namespace eCommerce.Core;

public static class DependencyInjection
{
    /// <summary>
    ///  Extension method to add infrastructure services to the dependency  injection container.
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddSingleton<IUserService, UserService>();
        return services;

    }
}
