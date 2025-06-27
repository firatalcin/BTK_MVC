using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Entities.Models;

namespace Store.Repositories.Config;

public class CategoryConfig : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
        
        builder.HasData(
            new Category(){ Id = 1, Name = "Book"},
            new Category(){ Id = 2, Name = "Electronic"}
            );
    }
}