using System.ComponentModel.DataAnnotations;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
    public int ReleaseYear { get; set; }
    [Range(0, 10)]
    public decimal Rating { get; set; }
    public int Duration { get; set; }
    public string PosterUrl { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public List<Review> Reviews { get; set; } = new();

}