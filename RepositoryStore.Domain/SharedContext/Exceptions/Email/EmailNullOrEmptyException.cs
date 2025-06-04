namespace RepositoryStore.Domain.SharedContext.Exceptions.Email;

public class EmailNullOrEmptyException(string message) : DomainException(message);