﻿using Microsoft.EntityFrameworkCore;
using RepositoryStore.Infrastructure.Data;
using RepositoryStore.Domain.ProductContext.Entities;
using RepositoryStore.Domain.ProductContext.Repositories.Abstractions;
using RepositoryStore.Domain.SharedContext.Specifications.Abstractions;

namespace RepositoryStore.Infrastructure.Repositories;

public class ProductRepository(AppDbContext context) : IProductRepository
{
    public async Task<Product?> GetByIdAsync(Specification<Product> specification, CancellationToken cancellationToken = default) 
        => await context.Products
            .AsNoTracking()
            .Where(specification.ToExpression())
            .FirstOrDefaultAsync(cancellationToken);

    public async Task<IEnumerable<Product>> GetAllAsync(int skip = 0, int take = 25, CancellationToken cancellationToken = default)
        => await context.Products
            .AsNoTracking()
            .Skip(skip).Take(take)
            .ToListAsync(cancellationToken);

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