using RepositoryStore.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using RepositoryStore.Infrastructure.Repositories;
using RepositoryStore.Domain.SharedContext.Repositories.Abstractions;
using RepositoryStore.Domain.ProductContext.Repositories.Abstractions;

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