using Scalar.AspNetCore;

namespace RepositoryStore.Api.Extensions;

public static class OpenApiConfig
{
    public static void AddOpenApiConfig(this WebApplication app)
    {
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.MapScalarApiReference(options =>
            {
                options.Title = "RepositoryStore.Api - Api List";
                options.DarkMode = true;
                options.Layout = ScalarLayout.Modern;
                options.HideClientButton = true;
            });
        }
    }
}