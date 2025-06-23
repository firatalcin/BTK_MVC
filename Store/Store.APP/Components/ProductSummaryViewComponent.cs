using Microsoft.AspNetCore.Mvc;
using Store.Repositories;
using Store.Services.Contracts;

namespace Store.APP.Components;

public class ProductSummaryViewComponent : ViewComponent
{
    private readonly IServiceManager _serviceManager;

    public ProductSummaryViewComponent(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    public string Invoke()
    {
        return _serviceManager.ProductService.GetAllProducts(false).Count().ToString();
    }
}