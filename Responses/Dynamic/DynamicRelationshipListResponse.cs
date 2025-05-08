using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Responses.Dynamic
{
    public class DynamicRelationshipListResponse
    {
        public List<DynamicRelationshipResponse> Relacionamentos { get; set; } = new();
    }
}
