using MediatR;
using RepositoryStore.Domain.SharedContext.Results;
using RepositoryStore.Domain.ProductContext.Entities;
using RepositoryStore.Domain.SharedContext.Repositories.Abstractions;
using RepositoryStore.Domain.ProductContext.Repositories.Abstractions;

namespace RepositoryStore.Application.ProductContext.UseCases.Create;

public class Handler(IProductRepository repository, IUnitOfWork unitOfWork) : IRequestHandler<Command, Result<Response>>
{
    public async Task<Result<Response>> Handle(Command request, CancellationToken cancellationToken)
    {
        var product = new Product()
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
        };

        await repository.CreateAsync(product, cancellationToken);
        await unitOfWork.CommitAsync();

        return Result.Success(new Response("Product Created"));
    }
}