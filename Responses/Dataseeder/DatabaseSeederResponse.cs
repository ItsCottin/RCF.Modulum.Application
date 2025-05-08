using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Responses.Dataseeder
{
    public class DatabaseSeederResponse
    {
        public List<RoleResponse> Role { get; set; }
        public List<UsuariosResponse> Usuarios { get; set; }
    }
}
