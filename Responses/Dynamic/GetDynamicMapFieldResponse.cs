using modulum.Application.Requests.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Responses.Dynamic
{
    public class GetDynamicMapFieldResponse : BaseDynamicFieldRequest
    {
        public int Id { get; set; }
    }
}
