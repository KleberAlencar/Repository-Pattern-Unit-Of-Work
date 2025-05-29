using System.Linq.Expressions;

namespace RepositoryStore.Domain.Abstractions;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> ToExpression();   
    bool IsSatisfiedBy(T entity);   
}