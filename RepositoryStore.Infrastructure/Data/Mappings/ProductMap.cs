using Microsoft.EntityFrameworkCore;
using RepositoryStore.Domain.ProductContext.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace RepositoryStore.Infrastructure.Data.Mappings;

public class ProductMap : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("Products");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Title)
            .IsRequired(true)
            .HasMaxLength(160)
            .HasColumnType("nvarchar(160)");
    }
}