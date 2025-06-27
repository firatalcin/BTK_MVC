using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Store.Entities.Models;

namespace Store.Repositories.Config;

public class ProductConfig : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired();
        builder.Property(x => x.Price).IsRequired();
        
        builder.HasData(
            new Product(){ Id = 1 ,CategoryId=2, Name = "Computer", Price = 17000},
            new Product(){ Id = 2 ,CategoryId=2, Name = "Keyboard", Price = 1000},
            new Product(){ Id = 3 ,CategoryId=2, Name = "Mouse", Price = 500},
            new Product(){ Id = 4 ,CategoryId=2, Name = "Monitor", Price = 7000},
            new Product(){ Id = 5 ,CategoryId=2, Name = "Deck", Price = 1500},
            new Product(){ Id = 6 ,CategoryId=1, Name = "History", Price = 25},
            new Product(){ Id = 7 ,CategoryId=1, Name = "Hamlet", Price = 45}
        );
    }
}