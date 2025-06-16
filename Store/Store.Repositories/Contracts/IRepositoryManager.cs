namespace Store.Repositories.Contracts;

public interface IRepositoryManager
{
    IProductRepository Product { get; }
    void Save();
}