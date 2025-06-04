namespace RepositoryStore.Domain.SharedContext.Exceptions.Email;

public class InvalidEmailException(string message) : DomainException(message);