using Microsoft.AspNetCore.Mvc;

namespace Template.Web.MVC.Controllers
{
    public class StudentiController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var studenti = new List<Studente>();
            studenti.Add(new Studente { Nome = "Mario", Matricola = "A1", Cognome = "Rossi", Id = 1 });
            studenti.Add(new Studente { Nome = "Mario", Matricola = "A2", Cognome = "Rossini", Id = 2 });
            studenti.Add(new Studente { Nome = "Mario", Matricola = "A3", Cognome = "Rossetti", Id = 3 });
            studenti.Add(new Studente { Nome = "Mario", Matricola = "A4", Cognome = "Russo", Id = 4 });

            return View(studenti);
        }
    }
}
