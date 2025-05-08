using FluentValidation;
using modulum.Application.Requests.Dynamic.Update;
using modulum.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Dynamic
{
    public class UpdateDynamicFieldRequestValidator : AbstractValidator<UpdateDynamicFieldRequest>
    {
        public UpdateDynamicFieldRequestValidator()
        {
            RuleFor(request => request.Id).NotNull().WithMessage(x => "Campo 'Id' do objeto 'Campos' é obrigatório");
            RuleFor(request => request.NomeCampoTela).Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Nome do Campo' é obrigatório");
            RuleFor(request => request.Tipo).NotNull().WithMessage(x => "Campo 'Tipo' é obrigatório");
            RuleFor(c => c.NomeCampoTela).Matches("^[a-zA-Z0-9_ ]+$").WithMessage("O nome do 'NomeCampoBase' deve conter apenas letras, números e underline."); // Impedir SQL Injection, precisa ser avaliado se é nescessario mais validações
            RuleFor(c => c.NomeCampoBase).Matches("^[a-zA-Z0-9_ ]+$").WithMessage("O nome do 'NomeCampoBase' deve conter apenas letras, números e underline.");
            RuleFor(c => c.Tamanho)
            .NotNull()
            .When(c => c.Tipo is TypeColumnEnum.VARCHAR)
            .WithMessage("O campo 'Tamanho' é obrigatório quando o tipo for 'Texto'.");
            RuleFor(c => c.Tamanho)
            .NotNull()
            .GreaterThan(0)
            .LessThanOrEqualTo(255)
            .When(c => c.Tipo is TypeColumnEnum.VARCHAR)
            .WithMessage("O campo 'Tamanho' deve ser informado, maior que zero e no máximo 255 para o tipo 'Texto'.");
        }
    }
}
