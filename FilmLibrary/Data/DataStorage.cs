using FilmLibrary.Models;
using Microsoft.AspNetCore.Components.Web;

namespace FilmLibrary.Data;

public static class DataStorage
{
    public static List<Film> Films = new()
    {
        new Film() {Id = 1, ImagePath = "\\Images\\Diego DMC.png", Title = "Reznya Chertey", AgeRestriction = "18+", Plot = "Plot", Description = "Description"},
        new Film() {Id = 2,ImagePath = "\\Images\\DOOM DIEGO.png", Title = "DoomM the Peak ages", AgeRestriction = "18+", Plot = "Plot", Description = "Descroption"},
        new Film() {Id = 3, ImagePath = "\\Images\\gerfds.png", Title = "Novenkiy", AgeRestriction = "18+", Plot = "Plot", Description = "Description"},
        new Film() {Id = 4, ImagePath = "\\Images\\On yak.png", Title = "On yak", AgeRestriction = "13+", Plot = "Plot", Description = "Description"}
    };
}