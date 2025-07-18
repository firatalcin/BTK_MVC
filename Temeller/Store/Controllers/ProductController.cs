using Microsoft.AspNetCore.Mvc;
using Store.Models;

namespace Store.Controllers;

public class ProductController : Controller
{
    private readonly RepositoryContext _context;

    public ProductController(RepositoryContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var model = _context.Products.ToList();
        return View(model);
    }

    public IActionResult Get(int id)
    {
        var product = _context.Products.Find(id);
        return View(product);
    }
}