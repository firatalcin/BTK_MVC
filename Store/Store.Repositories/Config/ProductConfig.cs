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
            new Product(){ Id = 1 ,CategoryId=2, ImageUrl="/images/1.jpg", Name = "Computer", Price = 17000},
            new Product(){ Id = 2 ,CategoryId=2, ImageUrl="/images/2.jpg", Name = "Keyboard", Price = 1000},
            new Product(){ Id = 3 ,CategoryId=2, ImageUrl="/images/3.jpg", Name = "Mouse", Price = 500},
            new Product(){ Id = 4 ,CategoryId=2, ImageUrl="/images/4.jpg", Name = "Monitor", Price = 7000},
            new Product(){ Id = 5 ,CategoryId=2, ImageUrl="/images/5.jpg", Name = "Deck", Price = 1500},
            new Product(){ Id = 6 ,CategoryId=1, ImageUrl="/images/6.jpg", Name = "History", Price = 25},
            new Product(){ Id = 7 ,CategoryId=1, ImageUrl="/images/7.jpg", Name = "Hamlet", Price = 45}
        );
    }
}