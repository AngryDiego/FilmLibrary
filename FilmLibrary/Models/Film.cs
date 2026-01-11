namespace FilmLibrary.Models;

public class Film
{
    public int Id { get; set; }
    
    public string ImagePath { get; set; }
    
    public string Title { get; set; }
    
    public string AgeRestriction { get; set; }
    
    public string Plot { get; set; }
    
    public string Description { get; set; }
}