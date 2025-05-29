using RepositoryStore.Domain.Abstractions;

namespace RepositoryStore.Infrastructure.Data;

public class UnitOfWork(AppDbContext context) : IUnitOfWork
{
    public async Task CommitAsync() => await context.SaveChangesAsync();       
}