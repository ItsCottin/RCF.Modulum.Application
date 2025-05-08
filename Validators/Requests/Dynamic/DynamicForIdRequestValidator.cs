using FluentValidation;
using modulum.Application.Requests.Dynamic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Dynamic
{
    public class DynamicForIdRequestValidator : AbstractValidator<DynamicForIdRequest>
    {
        public DynamicForIdRequestValidator() 
        {
            RuleFor(request => request.IdTable).NotNull().WithMessage(x => "Campo 'IdTable' é obrigatório");
            RuleFor(request => request.IdRegistro).NotNull().WithMessage(x => "Campo 'IdRegistro' é obrigatório");
        }
    }
}
