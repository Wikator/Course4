using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.User;

public class LoginUserDto
{
    [EmailAddress]
    [Required]
    public required string Email { get; set; }

    [Required]
    public required string Password { get; set; }
}