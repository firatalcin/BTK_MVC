﻿using Microsoft.AspNetCore.Mvc;
using Store.Services.Contracts;

namespace Store.APP.Components;

public class CategoriesMenuViewComponent : ViewComponent
{
    private readonly IServiceManager _serviceManager;

    public CategoriesMenuViewComponent(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    public IViewComponentResult Invoke()
    {
        var categories = _serviceManager.CategoryService.GetAllCategories(false);
        return View(categories);
    }
}