using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Store.Repositories.Contracts;

namespace Store.Repositories;

public abstract class RepositoryBase<T> : IRepositoryBase<T>
where T : class, new()
{
    protected readonly RepositoryContext _context;

    protected RepositoryBase(RepositoryContext context)
    {
        _context = context;
    }
    
    public IQueryable<T> FindAll(bool trackChanges)
    {
        return trackChanges ? _context.Set<T>() : _context.Set<T>().AsNoTracking();
    }

    public T? FindByCondition(Expression<Func<T, bool>> predicate, bool trackChanges)
    {
        return trackChanges ? 
            _context.Set<T>().SingleOrDefault(predicate) : 
            _context.Set<T>().AsNoTracking().SingleOrDefault(predicate);
    }

    public void Create(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }
}