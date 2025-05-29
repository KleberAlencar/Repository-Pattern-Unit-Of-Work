using MediatR;
using RepositoryStore.Domain.Results;
using RepositoryStore.Domain.Repositories.Abstractions;
using RepositoryStore.Domain.Specifications.Products;

namespace RepositoryStore.Application.UseCases.Products.GetById;

public sealed class Handler(IProductRepository repository) : IRequestHandler<Command, Result<Response>>
{
    public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        var spec = new GetProductByIdSpecification(request.Id);
        var product = await repository.GetByIdAsync(spec, cancellationToken);
        if (product is null) Result.Failure<Response>(new Error("404", "Product Not Found"));

        return Result.Success(new Response(product.Id, product.Title));
    }
}