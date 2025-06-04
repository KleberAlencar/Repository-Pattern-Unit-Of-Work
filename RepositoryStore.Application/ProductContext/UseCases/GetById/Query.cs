using MediatR;
using RepositoryStore.Domain.SharedContext.Results;

namespace RepositoryStore.Application.ProductContext.UseCases.GetById;

public sealed record Query(Guid Id) : IRequest<Result<Response>>;