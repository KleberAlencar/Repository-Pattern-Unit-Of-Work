using Microsoft.Extensions.DependencyInjection;

namespace RepositoryStore.Application;

public static class DepencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(x =>
        {
            x.RegisterServicesFromAssemblies(typeof(DepencyInjection).Assembly);
        });
        return services;       
    }
}