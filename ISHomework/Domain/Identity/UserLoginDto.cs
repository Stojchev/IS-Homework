namespace ISDomain.Identity
{
    using System.ComponentModel.DataAnnotations;
    public class UserLoginDto
    {
        [Required(ErrorMessage = "Email address is required")]
        [EmailAddress(ErrorMessage = "Email address is invalid")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me!")]
        public bool RememberMe { get; set; }
    }
}
