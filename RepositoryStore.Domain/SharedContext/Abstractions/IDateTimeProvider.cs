namespace RepositoryStore.Domain.SharedContext.Abstractions;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}