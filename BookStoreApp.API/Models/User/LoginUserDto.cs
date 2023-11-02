﻿using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.API.Models.User;

public class LoginUserDto
{
    [EmailAddress]
    public required string Email { get; set; }

    public required string Password { get; set; }
}