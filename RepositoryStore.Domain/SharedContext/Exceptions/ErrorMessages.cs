namespace RepositoryStore.Domain.SharedContext.Exceptions;

public abstract class ErrorMessages
{
    #region[ Properties ]
    public static EmailErrorMessages Email { get; } = new();

    #endregion
    
    public class EmailErrorMessages
    {
        public string Invalid { get; } = "Invalid Email";
        public string NullOrEmpty { get; } = "E-mail address cannot be null or empty";
    }
}