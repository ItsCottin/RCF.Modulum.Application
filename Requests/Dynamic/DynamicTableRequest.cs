using modulum.Application.Requests.Dynamic;
using modulum.Application.Requests.Dynamic.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Dynamic
{
    public class DynamicTableRequest : BaseDynamicTableRequest
    {

        public int Id { get; set; } 
        public List<DynamicDadoRequest> Resultados { get; set; } = null!;
    }
}
