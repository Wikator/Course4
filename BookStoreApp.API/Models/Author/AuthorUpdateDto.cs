using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.Author
{
    public class AuthorUpdateDto
    {
        [StringLength(50)]
        [Required]
        public required string FirstName { get; set; }

        [StringLength(50)]
        [Required]
        public required string LastName { get; set; }

        [StringLength(250)]
        public string? Bio { get; set; }
    }
}
