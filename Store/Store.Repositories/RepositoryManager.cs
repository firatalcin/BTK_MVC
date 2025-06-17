using Store.Repositories.Contracts;

namespace Store.Repositories;

public class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _context;
    private readonly IProductRepository _productRepository;
    private readonly ICategoryRepository _categoryRepository;

    public RepositoryManager(IProductRepository productRepository, ICategoryRepository categoryRepository, RepositoryContext context)
    {
        _productRepository = productRepository;
        _categoryRepository = categoryRepository;
        _context = context;
    }
    
    public IProductRepository Product => _productRepository;
    public ICategoryRepository Category => _categoryRepository;

    public void Save()
    {
        _context.SaveChanges();
    }
}