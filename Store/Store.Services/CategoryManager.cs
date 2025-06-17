using Store.Entities.Models;
using Store.Repositories.Contracts;
using Store.Services.Contracts;

namespace Store.Services;

public class CategoryManager : ICategoryService
{
    private readonly IRepositoryManager _repositoryManager;

    public CategoryManager(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }

    public IEnumerable<Category> GetAllCategories(bool trackChanges)
    {
        return _repositoryManager.Category.FindAll(trackChanges);
    }

    public Category? GetOneCategory(int categoryId, bool trackChanges)
    {
        var category = _repositoryManager.Category.FindByCondition(x => x.Id == categoryId, trackChanges);
        if (category is null)
        {
            throw new Exception("Category not found");
        }
        
        return category;
    }
}