using System.Linq.Expressions;

namespace RepositoryStore.Domain.SharedContext.Specifications.Abstractions;

public interface ISpecification<T>
{
    Expression<Func<T, bool>> ToExpression();   
    bool IsSatisfiedBy(T entity);   
}