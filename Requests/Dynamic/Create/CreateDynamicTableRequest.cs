using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Dynamic.Create
{
    public class CreateDynamicTableRequest : BaseDynamicTableRequest
    {
        public List<CreateDynamicFieldRequest> Campos { get; set; } = null!;
    }
}
