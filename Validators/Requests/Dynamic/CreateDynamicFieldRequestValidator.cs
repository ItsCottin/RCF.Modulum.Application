using FluentValidation;
using modulum.Application.Requests.Dynamic.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Dynamic
{
    public class CreateDynamicFieldRequestValidator : AbstractValidator<CreateDynamicFieldRequest>
    {
        public CreateDynamicFieldRequestValidator() 
        {
            RuleFor(request => request.NomeCampoTela).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Nome do Campo' é obrigatório");
            RuleFor(request => request.Tipo).NotNull().WithMessage(x => "Campo 'Tipo' é obrigatório");
            RuleFor(c => c.NomeCampoBase).Matches("^[a-zA-Z0-9_]+$").WithMessage("O nome do 'NomeCampoBase' deve conter apenas letras, números e underline."); // Impedir SQL Injection, precisa ser avaliado se é nescessario mais validações
        }
    }
}
