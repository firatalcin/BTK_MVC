using Store.Entities.Models;
using Store.Repositories.Contracts;

namespace Store.Repositories;

public class ProductRepository : RepositoryBase<Product>,IProductRepository
{
    public ProductRepository(RepositoryContext context) : base(context)
    {
    }

    public IQueryable<Product> GetAllProducts(bool trackChanges)
    {
        return FindAll(trackChanges);
    }

    public Product? GetOneProduct(int id, bool trackChanges)
    {
        return FindByCondition(x => x.Id == id, trackChanges);
    }

    public void CreateProduct(Product product)
    {
        Create(product);
    }
}