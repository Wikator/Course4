using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.User;

public class UserDto
{
    [EmailAddress]
    [Required]
    public required string Email { get; set; }
    
    [Required]
    public required string Password { get; set; }
    
    [Required]
    public required string FirstName { get; set; }
    
    [Required]
    public required string LastName { get; set; }
    
    public string? Role { get; set; }
}