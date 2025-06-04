using MediatR;
using RepositoryStore.Domain.SharedContext.Results;
using RepositoryStore.Domain.ProductContext.Specifications;
using RepositoryStore.Domain.ProductContext.Repositories.Abstractions;

namespace RepositoryStore.Application.ProductContext.UseCases.GetById;

public sealed class Handler(IProductRepository repository) : IRequestHandler<Query, Result<Response>>
{
    public async Task<Result<Response>> Handle(Query request, CancellationToken cancellationToken)
    {
        var spec = new GetProductByIdSpecification(request.Id);
        var product = await repository.GetByIdAsync(spec, cancellationToken);
        if (product is null) Result.Failure<Response>(new Error("404", "Product Not Found"));

        return Result.Success(new Response(product.Id, product.Title));
    }
}