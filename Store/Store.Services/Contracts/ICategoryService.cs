using Store.Entities.Models;

namespace Store.Services.Contracts;

public interface ICategoryService
{
    IEnumerable<Category> GetAllCategories(bool trackChanges);
    Category? GetOneCategory(int categoryId, bool trackChanges);
}