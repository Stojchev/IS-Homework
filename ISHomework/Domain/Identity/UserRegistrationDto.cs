﻿namespace ISDomain.Identity
{
    using ISDomain.Identity.Enum;
    using System.ComponentModel.DataAnnotations;
    public class UserRegistrationDto
    {
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Email address is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password confirmation is required")]
        [Compare("Password", ErrorMessage = "The Password and Password Confirmation do not match")]
        public string ConfirmPassword { get; set; }
        public Role UserRole;
    }
}
