using modulum.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Dynamic.Relationship
{
    public class CreateDynamicRelationshipRequest
    {
        public int TabelaOrigemId { get; set; }
        public int TabelaDestinoId { get; set; }
        public string? CampoOrigem { get; set; }
        public string? CampoDestino { get; set; }
        public TypeRelationshipEnum Tipo { get; set; }
        public bool IsObrigatorio { get; set; }
        public string? CampoParaExibicaoRelacionamento { get; set; }
    }
}
