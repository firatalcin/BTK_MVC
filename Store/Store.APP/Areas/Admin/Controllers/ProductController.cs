using Microsoft.AspNetCore.Mvc;
using Store.Entities.Models;
using Store.Services.Contracts;

namespace Store.APP.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller
{
    private readonly IServiceManager _serviceManager;

    public ProductController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    public IActionResult Index()
    {
        var model = _serviceManager.ProductService.GetAllProducts(false);
        return View(model);
    }

    public IActionResult Create()
    {
        return View();
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([FromForm] Product product)
    { 
        return View();
    }
}