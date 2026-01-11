using Microsoft.AspNetCore.Mvc;

namespace FilmLibrary.Controllers;

public class FilmController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}