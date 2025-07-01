using AutoMapper;
using Store.Entities.Dtos;
using Store.Entities.Models;
using Store.Repositories.Contracts;
using Store.Services.Contracts;

namespace Store.Services;

public class ProductManager : IProductService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;

    public ProductManager(IRepositoryManager repositoryManager,  IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
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

    public void CreateProduct(ProductDtoForInsertion productDtoForInsertion)
    {
        Product product = _mapper.Map<Product>(productDtoForInsertion);
         
        _repositoryManager.Product.CreateProduct(product);
        _repositoryManager.Save();
    }

    public void UpdateOneProduct(ProductDtoForUpdate productDtoForUpdate)
    {
        //var entity = _repositoryManager.Product.GetOneProduct(productDtoForUpdate.Id, true);
        // entity.Name = productDtoForUpdate.Name;
        // entity.Price = productDtoForUpdate.Price;
        // entity.CategoryId = productDtoForUpdate.CategoryId;
        
        var entity = _mapper.Map<Product>(productDtoForUpdate);
        _repositoryManager.Product.UpdateOneProduct(entity);
        _repositoryManager.Save();
    }

    public void DeleteOneProduct(int id)
    {
        var product = GetOneProduct(id, false);
        if (product is not null)
        {
            _repositoryManager.Product.DeleteOneProduct(product);
            _repositoryManager.Save();
        }
    }

    public ProductDtoForUpdate GetOneProductForUpdate(int id, bool trackChanges)
    {
        var product = GetOneProduct(id, trackChanges);
        var productDto = _mapper.Map<ProductDtoForUpdate>(product);
        return productDto;
    }
}