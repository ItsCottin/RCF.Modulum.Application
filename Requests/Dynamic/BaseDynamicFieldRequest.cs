using modulum.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Requests.Dynamic
{
    public class BaseDynamicFieldRequest
    {
        public string? NomeCampoBase { get; set; }
        public string? NomeCampoTela { get; set; }
        public TypeColumnEnum? Tipo { get; set; }
        public int? Tamanho { get; set; }
        public bool IsPrimaryKey { get; set; }
        public bool IsObrigatorio { get; set; }
    }
}
