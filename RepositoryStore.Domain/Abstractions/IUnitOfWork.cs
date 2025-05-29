namespace RepositoryStore.Domain.Abstractions;

public interface IUnitOfWork
{
    Task CommitAsync();   
}