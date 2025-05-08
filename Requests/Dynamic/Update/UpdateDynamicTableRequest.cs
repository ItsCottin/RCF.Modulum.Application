using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Dynamic.Update
{
    public class UpdateDynamicTableRequest : BaseDynamicTableRequest
    {
        public int? Id { get; set; }
        public List<UpdateDynamicFieldRequest> Campos { get; set; } = new();
    }
}
