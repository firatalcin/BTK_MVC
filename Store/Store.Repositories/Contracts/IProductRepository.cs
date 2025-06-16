using Store.Entities.Models;

namespace Store.Repositories.Contracts;

public interface IProductRepository : IRepositoryBase<Product>
{
    IQueryable<Product> GetAllProducts(bool trackChanges);
    Product? GetOneProduct(int id, bool trackChanges);
}