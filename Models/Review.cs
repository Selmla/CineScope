using System.ComponentModel.DataAnnotations;

public class Review
{
    public int Id { get; set; }
    
    [Required]
    public string Content { get; set; } = string.Empty;
    
    [Range(1, 10)]
    public int Rating { get; set; }
    
    public string UserId { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    
    // Relation till Movie
    public int MovieId { get; set; }
    public Movie? Movie { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}