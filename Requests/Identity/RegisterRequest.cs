using System.ComponentModel.DataAnnotations;

namespace modulum.Application.Requests.Identity
{
    public class RegisterRequest
    {
        [Required(ErrorMessage = "O Campo 'Nome Completo' é Obrigatório")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "O Campo 'E-Mail' é Obrigatório")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo 'Usuario' é Obrigatório")]
        [MinLength(6)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O Campo 'Senha' é Obrigatório")]
        [MinLength(6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "O Campo 'Confirme sua Senha' é Obrigatório")]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public bool EmailConfirmed { get; set; }
    }
}