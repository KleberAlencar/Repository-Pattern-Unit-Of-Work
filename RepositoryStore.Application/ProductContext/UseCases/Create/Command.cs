using MediatR;
using RepositoryStore.Domain.SharedContext.Results;

namespace RepositoryStore.Application.ProductContext.UseCases.Create;

public record Command(string Title) : IRequest<Result<Response>>;