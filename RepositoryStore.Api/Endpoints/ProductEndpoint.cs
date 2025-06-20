﻿using MediatR;

namespace RepositoryStore.Api.Endpoints;

public static class ProductEndpoint
{
    public static RouteGroupBuilder AddMapProductEndpoints(this RouteGroupBuilder groupBuilder)
    {
        groupBuilder.MapGet("/{id:Guid}", async (ISender sender, Guid id, CancellationToken cancellationToken) =>
        {
            var command = new Application.ProductContext.UseCases.GetById.Query(id);
            var result = await sender.Send(command, cancellationToken);
            if (!result.IsSuccess) Results.BadRequest(result.Error);
            
            return Results.Ok(result.Value);       
        });

        groupBuilder.MapPost("/", async (
            ISender sender, 
            Application.ProductContext.UseCases.Create.Command command, 
            CancellationToken cancellationToken) =>
        {
            var result = await sender.Send(command, cancellationToken);
            if (!result.IsSuccess) Results.BadRequest(result.Error);
            
            return Results.Ok(result.Value);       
        });
        
        return groupBuilder;       
    }    
}