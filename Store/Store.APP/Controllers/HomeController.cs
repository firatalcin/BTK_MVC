using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Store.APP.Models;

namespace Store.APP.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}