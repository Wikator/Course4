namespace BookStoreApp.API.Models.Book;

public class BookDetailsDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public int Year { get; set; }
    public required string Isbn { get; set; }
    public string? Image { get; set; }
    public required decimal Price { get; set; }
    public int AuthorId { get; set; }
    public required string AuthorName { get; set; }
}