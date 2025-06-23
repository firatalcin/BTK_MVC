using Microsoft.AspNetCore.Mvc;

namespace Store.APP.Areas.Admin.Controllers;

[Area("Admin")]
public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}