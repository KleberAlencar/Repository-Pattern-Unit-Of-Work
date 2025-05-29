using Microsoft.EntityFrameworkCore;
using RepositoryStore.Domain.Entities;
using RepositoryStore.Infrastructure.Data;
using RepositoryStore.Domain.Specifications;
using RepositoryStore.Domain.Repositories.Abstractions;

namespace RepositoryStore.Infrastructure.Repositories;

public class ProductRepository(AppDbContext context) : IProductRepository
{
    public async Task<Product?> GetByIdAsync(Specification<Product> specification, CancellationToken cancellationToken = default) 
        => await context.Products
            .AsNoTracking()
            .Where(specification.ToExpression())
            .FirstOrDefaultAsync(cancellationToken);

    public Task<IEnumerable<Product>> GetAllAsync(int skip = 0, int take = 25, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public async Task CreateAsync(Product product, CancellationToken cancellationToken = default)
        =>  await context.Products.AddAsync(product, cancellationToken);

    public Task UpdateAsync(Product product, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}