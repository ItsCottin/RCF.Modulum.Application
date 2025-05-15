using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCF.Modulum.Application.Requests.Identity
{
    public class CadastroExternoRequest
    {
        [Required(ErrorMessage = "O Campo 'CPF' é Obrigatório")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "O Campo 'E-Mail' é Obrigatório")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo 'Password' é Obrigatório")]
        public string Password { get; set; }
    }
}
