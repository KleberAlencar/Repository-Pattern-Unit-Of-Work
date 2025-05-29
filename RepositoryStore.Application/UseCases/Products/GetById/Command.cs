using MediatR;
using RepositoryStore.Domain.Results;

namespace RepositoryStore.Application.UseCases.Products.GetById;

public sealed record Command(Guid Id) : IRequest<Result<Response>>;