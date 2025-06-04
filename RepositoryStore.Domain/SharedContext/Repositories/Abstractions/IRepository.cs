using RepositoryStore.Domain.SharedContext.AggregateRoots.Abstractions;

namespace RepositoryStore.Domain.SharedContext.Repositories.Abstractions;

public interface IRepository<TAggregateRoot> where TAggregateRoot : IAggregateRoot;