using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nodulum.Application.Requests.Identity
{
    public class FinishRegisterRequest
    {
        [Required(ErrorMessage = "O Campo 'E-Mail' é Obrigatório")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo 'Senha' é Obrigatório")]
        [MinLength(6)]
        public string Password { get; set; }

        [Required(ErrorMessage = "O Campo 'Confirme sua Senha' é Obrigatório")]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
