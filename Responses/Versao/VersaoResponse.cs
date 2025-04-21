using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Responses.Versao
{
    public class VersaoResponse
    {
        public int Id { get; set; }
        public string Pacote { get; set; }
        public string RequestedVersion { get; set; }
        public string ResolvedVersion { get; set; }
        public string Framework { get; set; }
        public string PacoteRaiz { get; set; }
    }
}
