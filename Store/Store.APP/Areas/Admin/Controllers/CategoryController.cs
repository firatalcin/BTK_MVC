﻿using Microsoft.AspNetCore.Mvc;

namespace Store.APP.Areas.Admin.Controllers;

[Area("Admin")]
public class CategoryController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}