using Microsoft.Extensions.DependencyInjection;
using RepositoryStore.Domain.Abstractions;
using RepositoryStore.Infrastructure.Repositories;
using RepositoryStore.Domain.Repositories.Abstractions;
using RepositoryStore.Infrastructure.Data;

namespace RepositoryStore.Infrastructure;

public static class DepencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddTransient<IProductRepository, ProductRepository>();
        return services;       
    }
}