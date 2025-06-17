using Store.Entities.Models;
using Store.Repositories.Contracts;
using Store.Services.Contracts;

namespace Store.Services;

public class ProductManager : IProductService
{
    private readonly IRepositoryManager _repositoryManager;

    public ProductManager(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }
    
    public IEnumerable<Product> GetAllProducts(bool trackChanges)
    {
        return _repositoryManager.Product.GetAllProducts(trackChanges);
    }

    public Product? GetOneProduct(int productId, bool trackChanges)
    {
        var product = _repositoryManager.Product.GetOneProduct(productId, trackChanges);
        if (product is null)
        {
            throw new Exception("Product not found");
        }
        return product;
        
    }
}