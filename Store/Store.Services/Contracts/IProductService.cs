using Store.Entities.Models;

namespace Store.Services.Contracts;

public interface IProductService
{
    IEnumerable<Product> GetAllProducts(bool trackChanges);
    Product? GetOneProduct(int productId, bool trackChanges);
}