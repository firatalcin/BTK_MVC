using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Store.Entities.Dtos;
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
        ViewBag.Categories = GetCategoriesSelectList();
        return View();
    }

    private SelectList GetCategoriesSelectList()
    {
        return new SelectList( _serviceManager.CategoryService.GetAllCategories(false),"Id", "Name", "1");
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([FromForm] ProductDtoForInsertion productDtoForInsertion, IFormFile file)
    {
        if (ModelState.IsValid)
        {
            //file operation
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","images", file.FileName);
            using(var  stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            
            productDtoForInsertion.ImageUrl = string.Concat("/images/", file.FileName);
            _serviceManager.ProductService.CreateProduct(productDtoForInsertion);
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Update([FromRoute(Name = "id")] int id)
    {
        ViewBag.Categories = GetCategoriesSelectList();
        var model = _serviceManager.ProductService.GetOneProductForUpdate(id, false);
        return View(model);
    }
    
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Update([FromForm] ProductDtoForUpdate productDto, IFormFile file)
    {
        if (ModelState.IsValid)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot","images", file.FileName);
            using(var  stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            
            productDto.ImageUrl = string.Concat("/images/", file.FileName);
            _serviceManager.ProductService.UpdateOneProduct(productDto);
            return RedirectToAction("Index");
        }
        
        return View();
    }

    public IActionResult Delete([FromRoute(Name = "id")] int id)
    {
        _serviceManager.ProductService.DeleteOneProduct(id);
        return RedirectToAction("Index");
    }
}