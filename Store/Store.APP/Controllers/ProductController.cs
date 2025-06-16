using Microsoft.AspNetCore.Mvc;
using Store.Repositories;
using Store.Repositories.Contracts;

namespace Store.APP.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepositoryManager _repositoryManager;

        public ProductController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public IActionResult Index()
        {
            var model = _repositoryManager.Product.GetAllProducts(false);
            return View(model);
        }

        public IActionResult Get(int id)
        {
            var product = _repositoryManager.Product.GetOneProduct(id, false);
            return View(product);
        }


    }
}
