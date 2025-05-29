using RepositoryStore.Domain.Abstractions;

namespace RepositoryStore.Domain.Entities;

public class Product : Entity, IAggregateRoot
{
    public string Title { get; set; } = string.Empty;
}