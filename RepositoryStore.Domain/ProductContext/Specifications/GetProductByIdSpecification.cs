using System.Linq.Expressions;
using RepositoryStore.Domain.ProductContext.Entities;
using RepositoryStore.Domain.SharedContext.Specifications.Abstractions;

namespace RepositoryStore.Domain.ProductContext.Specifications;

public class GetProductByIdSpecification(Guid id) : Specification<Product>
{
    public override Expression<Func<Product, bool>> ToExpression() 
        => product => product.Id == id;
}