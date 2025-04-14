using modulum.Application.Requests.Dynamic.Create;
using modulum.Application.Requests.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Dynamic
{
    public class DynamicDadoRequest
    {
        public int Id { get; set; } // Id do Registro na tabela dinamica
        public List<DynamicFieldRequest> Valores { get; set; } = null!;
    }
}
