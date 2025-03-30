using System.ComponentModel.DataAnnotations;

namespace modulum.Application.Requests.Identity
{
    public class TokenRequest
    {
        [Required(ErrorMessage = "O Campo 'E-Mail' é Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo 'Senha' é Obrigatório")]
        public string Password { get; set; }
    }
}