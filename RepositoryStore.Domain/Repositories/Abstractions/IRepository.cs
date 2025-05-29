using RepositoryStore.Domain.Abstractions;

namespace RepositoryStore.Domain.Repositories.Abstractions;

public interface IRepository<T> where T : IAggregateRoot;