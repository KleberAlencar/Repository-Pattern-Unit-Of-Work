using RepositoryStore.Application;
using Microsoft.EntityFrameworkCore;
using RepositoryStore.Api.Endpoints;
using RepositoryStore.Infrastructure;
using RepositoryStore.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"), b 
        => b.MigrationsAssembly("RepositoryStore.Api"));
});

builder.Services.AddApplication();
builder.Services.AddInfrastructure();
    
var app = builder.Build();
app.MapGroup("v1/products").AddMapProductEndpoints();

app.Run();