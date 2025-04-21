using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Versao
{
    public class ProjectInfoRequest
    {
        public string? Path { get; set; }
        public List<FrameworkInfoRequest>? Frameworks { get; set; }
    }
}
