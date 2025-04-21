using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Versao
{
    public class PackageListResultRequest
    {
        public int Version { get; set; }
        public string? Parameters { get; set; }
        public List<ProjectInfoRequest>? Projects { get; set; }
    }
}
