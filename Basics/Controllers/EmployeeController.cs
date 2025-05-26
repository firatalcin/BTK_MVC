using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            string message = $"Hello World. {DateTime.Now.ToString()}";
            return View(message);
        }

        public ViewResult Index2()
        {
            var names = new string[]{
                "Ahmet",
                "Mehmet",
                "Can"
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee(){Id= 1, FirstName = "Fırat", LastName = "Alçın", Age = 27},
                new Employee(){Id= 2, FirstName = "Can", LastName = "Dağ", Age = 32},
                new Employee(){Id= 3, FirstName = "Ahmet", LastName = "Yılmaz", Age = 35}
            };
            return View("Index3", list);
        }
    }
}