using System.Linq.Expressions;
using RepositoryStore.Domain.Entities;

namespace RepositoryStore.Domain.Specifications.Products;

public class GetProductByIdSpecification(Guid id) : Specification<Product>
{
    public override Expression<Func<Product, bool>> ToExpression() 
        => product => product.Id == id;
}