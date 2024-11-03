using ObsForm.Models;
using Microsoft.AspNetCore.Mvc;

namespace ObsForm.Controllers
{
    public class DaneController : Controller
    {
        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult Form() => View();

        [HttpPost]
        public IActionResult Form(Dane dane)
        {
            if (ModelState.IsValid)
                return View("Wynik", dane);
            else
                return View(dane);
        }

        public IActionResult Wynik(Dane dane) => View(dane);
    }
}