using RepositoryStore.Domain.Entities;
using RepositoryStore.Domain.Specifications;

namespace RepositoryStore.Domain.Repositories.Abstractions;

public interface IProductRepository : IRepository<Product>
{
    Task<Product?> GetByIdAsync(Specification<Product> specification, CancellationToken cancellationToken = default);
    Task<IEnumerable<Product>> GetAllAsync(int skip = 0, int take = 25, CancellationToken cancellationToken = default);
    Task CreateAsync(Product product, CancellationToken cancellationToken = default);
    Task UpdateAsync(Product product, CancellationToken cancellationToken = default);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken = default);   
}