using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.User;

public class UserDto
{
    [EmailAddress]
    public required string Email { get; set; }
    
    public required string Password { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Role { get; set; }
}