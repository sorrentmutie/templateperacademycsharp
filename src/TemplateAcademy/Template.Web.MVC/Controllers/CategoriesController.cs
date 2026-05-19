using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Template.Dati.Northwind.Models;

namespace Template.Web.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        private NorthwindContext database = new();


        public async Task<IActionResult> Index()
        {
            var categories = await database.Categories.ToListAsync();

            return View(categories);
        }
    }
}
