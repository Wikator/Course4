namespace BookStoreApp.API.Models.User;

public class AuthResponse
{
    public required string UserId { get; set; }
    public required string Token { get; set; }
    public required string Email { get; set; }
}