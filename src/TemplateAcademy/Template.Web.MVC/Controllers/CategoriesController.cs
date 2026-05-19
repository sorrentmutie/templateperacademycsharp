using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
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

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category nuovaCategoria)
        {
            database.Categories.Add(nuovaCategoria);
            await database.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
