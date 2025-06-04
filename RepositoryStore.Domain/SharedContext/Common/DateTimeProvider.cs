using RepositoryStore.Domain.SharedContext.Abstractions;

namespace RepositoryStore.Domain.SharedContext.Common;

public sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow { get; } = DateTime.UtcNow;
}