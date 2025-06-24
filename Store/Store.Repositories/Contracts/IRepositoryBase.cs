using System.Linq.Expressions;

namespace Store.Repositories.Contracts;

public interface IRepositoryBase<T>
{
    IQueryable<T> FindAll(bool trackChanges);
    T? FindByCondition(Expression<Func<T, bool>> predicate, bool trackChanges);
    void Create(T entity);
}