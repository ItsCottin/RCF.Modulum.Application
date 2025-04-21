using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Versao
{
    public class PackageInfoRequest
    {
        public string? Id { get; set; }
        public string? RequestedVersion { get; set; }
        public string? ResolvedVersion { get; set; }
    }
}
