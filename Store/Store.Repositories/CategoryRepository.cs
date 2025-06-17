using Store.Entities.Models;
using Store.Repositories.Contracts;

namespace Store.Repositories;

public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(RepositoryContext context) : base(context)
    {
    }
}