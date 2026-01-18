using Microsoft.AspNetCore.Mvc;
using FilmLibrary.Data;
using FilmLibrary.Models;
namespace FilmLibrary.Controllers;

public class FilmController : Controller
{
    
    // GET
    public IActionResult Index()
    {
        return View(DataStorage.Films);
    }
    
    //GET
    public IActionResult Description(int id)
    {
        Film film = DataStorage.Films.First(f => f.Id == id);
        return View(film);
    }
    
    
    //CRUD - operations (create-update-delete)
    
    //GET
    public IActionResult Create()
    {
        return View();
    }
    
    //POST
    [HttpPost]
    public IActionResult Create(Film film)
    {
        film.Id = DataStorage.Films.Count + 1;
        DataStorage.Films.Add(film);

        return View("Index");
    }
    
    //GET
    public IActionResult Edit(int id)
    {
        Film film = DataStorage.Films.First(f => f.Id == id);
        return View(film);
    }
    
    //POST
    /*
    public IActionResult Edit(Film film)
    {
        var removedFilm = DataStorage.Films.First(f => f.Id == film.Id);

        DataStorage.Films.Remove(removedFilm);
        DataStorage.Films.Add(film);

        return View("Index");
    }
    */
    
    //GET
    public IActionResult Delete(int id)
    {
        Film film = DataStorage.Films.First(f => f.Id == id);
        return View(film);
    }
    
    //POST
    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var removedFilm = DataStorage.Films.First(f => f.Id == id);
        DataStorage.Films.Remove(removedFilm);
        
        return View("Index");
    }
}