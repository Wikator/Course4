using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Book;

public class BookUpdateDto
{
    [StringLength(50)]
    public required string Title { get; set; }

    [Required]
    [Range(1800, int.MaxValue)]
    public int Year { get; set; }
    
    [StringLength(50)]
    public required string Isbn { get; set; }
    
    [StringLength(250, MinimumLength = 10)]
    public required string Summary { get; set; }

    [StringLength(50)]
    public string? Image { get; set; }
    
    [Required]
    [Range(0, int.MaxValue)]
    public decimal Price { get; set; }
    
    public int AuthorId { get; set; }
}