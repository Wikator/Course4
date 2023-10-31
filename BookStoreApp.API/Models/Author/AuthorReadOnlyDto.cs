namespace BookStoreApp.API.Models.Author
{
    public class AuthorReadOnlyDto
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public string? Bio { get; set; }
    }
}
