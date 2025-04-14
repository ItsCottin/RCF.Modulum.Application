using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Dynamic
{
    public class DynamicFieldRequest : BaseDynamicFieldRequest
    {
        public int Id { get; set; } // Id na 
        public int IdTabela { get; set; }
        public string? Valor { get; set; }
    }
}
