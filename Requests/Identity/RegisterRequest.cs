using System.ComponentModel.DataAnnotations;

namespace modulum.Application.Requests.Identity
{
    public class RegisterRequest
    {
        [Required]
        public string NomeCompleto { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public bool EmailConfirmed { get; set; }
    }
}