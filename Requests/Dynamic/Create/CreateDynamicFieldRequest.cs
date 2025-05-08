using modulum.Domain.Enums;
using modulum.Application.Requests.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace modulum.Application.Requests.Dynamic.Create
{
    public class CreateDynamicFieldRequest : BaseDynamicFieldRequest
    {
        [JsonIgnore]
        public Guid? TempId { get; set; }
        public int? Id { get; set; }
    }
}
