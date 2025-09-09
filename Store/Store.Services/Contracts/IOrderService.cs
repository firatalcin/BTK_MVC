using Store.Entities.Models;

namespace Store.Services.Contracts;

public interface IOrderService
{
    IQueryable<Order> Orders {get;}
    Order? GetOneOrder(int id);
    void Complete(int id);
    void SaveOrder(Order order);
    int NumberOfInProcess {get;}
}