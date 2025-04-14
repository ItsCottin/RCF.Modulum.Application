using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Dynamic
{
    public class BaseDynamicTableRequest
    {
        public string? NomeTabela { get; set; }
        public string? NomeTela { get; set; }
        public string? CampoPK { get; set; }
        public string? JsonObject { get; set; }
        public string? TelaObject { get; set; }
    }
}
