using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Versao
{
    public class FrameworkInfoRequest
    {
        public string? Framework { get; set; }
        public List<PackageInfoRequest>? TopLevelPackages { get; set; }
    }
}
