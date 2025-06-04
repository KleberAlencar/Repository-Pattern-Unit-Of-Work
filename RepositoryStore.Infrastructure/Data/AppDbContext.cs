using Microsoft.EntityFrameworkCore;
using RepositoryStore.Domain.ProductContext.Entities;

namespace RepositoryStore.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DepencyInjection).Assembly);
    }
}