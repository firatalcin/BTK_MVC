using Microsoft.AspNetCore.Mvc;
using Store.Repositories.Contracts;

namespace Store.APP.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IRepositoryManager _repositoryManager;

        public CategoryController(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }
        
        // GET: CategoryController
        public ActionResult Index()
        {
            var model = _repositoryManager.Category.FindAll(false);
            return View(model);
        }

    }
}
