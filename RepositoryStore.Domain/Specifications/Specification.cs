using System.Linq.Expressions;
using RepositoryStore.Domain.Abstractions;

namespace RepositoryStore.Domain.Specifications;

public abstract class Specification<T> : ISpecification<T>
{
    public abstract Expression<Func<T, bool>> ToExpression();

    public bool IsSatisfiedBy(T entity)
    {
        var predicate = ToExpression().Compile();
        return predicate(entity);       
    }
}