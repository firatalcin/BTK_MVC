using Store.Entities.Dtos;
using Store.Entities.Models;

namespace Store.Services.Contracts;

public interface IProductService
{
    IEnumerable<Product> GetAllProducts(bool trackChanges);
    Product? GetOneProduct(int productId, bool trackChanges);
    void CreateProduct(ProductDtoForInsertion productDtoForInsertion);
    void UpdateOneProduct(ProductDtoForUpdate productDtoForUpdate);
    void DeleteOneProduct(int id);
    ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges);
}