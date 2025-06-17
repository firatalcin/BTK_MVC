using Microsoft.AspNetCore.Mvc;
using Store.Repositories;
using Store.Repositories.Contracts;
using Store.Services.Contracts;

namespace Store.APP.Controllers
{
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

        public IActionResult Get([FromRoute(Name = "id")] int id)
        {
            var product = _serviceManager.ProductService.GetOneProduct(id, false);
            return View(product);
        }


    }
}
