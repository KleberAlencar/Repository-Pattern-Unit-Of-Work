namespace RepositoryStore.Domain.SharedContext.Repositories.Abstractions;

public interface IUnitOfWork
{
    Task CommitAsync();   
}