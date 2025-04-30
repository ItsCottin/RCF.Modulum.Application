using FluentValidation;
using modulum.Application.Requests.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Dynamic
{
    public class DynamicDadoRequestValidator : AbstractValidator<DynamicDadoRequest>
    {
        public DynamicDadoRequestValidator() 
        {
            RuleForEach(x => x.Valores).SetValidator(new DynamicFieldRequestValidator());
        }
    }
}
