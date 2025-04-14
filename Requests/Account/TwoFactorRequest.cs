using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Account
{
    public class TwoFactorRequest
    {
        [Required(ErrorMessage = "O Campo 'Email' é Obrigatório")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O Campo 'Code' é Obrigatório")]
        public string Code { get; set; }
    }
}
