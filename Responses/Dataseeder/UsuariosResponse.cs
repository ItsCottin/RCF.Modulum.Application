using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Responses.Dataseeder
{
    public class UsuariosResponse
    {
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool IsCadastroFinalizado { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
