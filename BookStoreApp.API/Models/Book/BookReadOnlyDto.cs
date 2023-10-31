using BookStoreApp.API.Models.Author;

namespace BookStoreApp.API.Models.Book;

public class BookReadOnlyDto
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Image { get; set; }
    public required decimal Price { get; set; }
    public int AuthorId { get; set; }
    public required string AuthorName { get; set; }
}