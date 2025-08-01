﻿using System.ComponentModel.DataAnnotations;

namespace furni1.ViewModels
{
    public class ForgotPasswordVM
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
