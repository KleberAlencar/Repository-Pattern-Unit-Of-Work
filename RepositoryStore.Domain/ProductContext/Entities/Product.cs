using RepositoryStore.Domain.SharedContext.Entities;
using RepositoryStore.Domain.SharedContext.AggregateRoots.Abstractions;

namespace RepositoryStore.Domain.ProductContext.Entities;

public class Product : Entity, IAggregateRoot
{
    public string Title { get; set; } = string.Empty;
}