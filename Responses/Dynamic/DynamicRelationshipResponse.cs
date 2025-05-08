using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Responses.Dynamic
{
    public class DynamicRelationshipResponse
    {
        public int IdTable { get; set; }
        public bool IsObrigatorio { get; set; }
        public string? NomeCampoTela { get; set; }
        public string? NomeCampoFK { get; set; }
        public List<RegistrosRelacionamentosResponse> Valores { get; set; } = new();

    }
}
