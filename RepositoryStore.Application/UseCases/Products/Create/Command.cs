using MediatR;
using RepositoryStore.Domain.Results;

namespace RepositoryStore.Application.UseCases.Products.Create;

public record Command(string Title) : IRequest<Result<Response>>;