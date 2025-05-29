using MediatR;
using RepositoryStore.Domain.Results;
using RepositoryStore.Domain.Entities;
using RepositoryStore.Domain.Abstractions;
using RepositoryStore.Domain.Repositories.Abstractions;

namespace RepositoryStore.Application.UseCases.Products.Create;

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