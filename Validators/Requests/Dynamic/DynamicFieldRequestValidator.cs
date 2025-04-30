using FluentValidation;
using modulum.Application.Requests.Dynamic;
using modulum.Shared.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Dynamic
{
    public class DynamicFieldRequestValidator : AbstractValidator<DynamicFieldRequest>
    {
        public DynamicFieldRequestValidator() 
        {
            RuleFor(x => x.Valor)
            .Custom((valor, context) =>
            {
                var campo = (DynamicFieldRequest)context.InstanceToValidate;

                if (campo.IsObrigatorio && string.IsNullOrWhiteSpace(valor))
                {
                    context.AddFailure($"O campo '{campo.NomeCampoTela}' é obrigatório.");
                }

                if (campo.Tipo == TypeColumnEnum.INT && !int.TryParse(valor, out _))
                {
                    context.AddFailure($"O campo '{campo.NomeCampoTela}' deve ser um número inteiro.");
                }

                if (campo.Tipo == TypeColumnEnum.DATE && !DateTime.TryParse(valor, out _))
                {
                    context.AddFailure($"O campo '{campo.NomeCampoTela}' deve ser uma data válida.");
                }

                // Regras adicionais aqui...
            });
        }
    }
}
