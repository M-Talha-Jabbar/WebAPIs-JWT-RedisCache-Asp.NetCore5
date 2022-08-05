﻿using System.ComponentModel.DataAnnotations;

namespace Service.ViewModels
{
    public class LoginViewModel
    {
        [Required][MaxLength(20)] public string Username { get; set; }
        [Required] public string Password { get; set; }
    }
}
