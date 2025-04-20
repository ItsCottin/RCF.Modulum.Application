using FluentValidation;
using modulum.Application.Requests.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Identity
{
    public class PreRegistroRequestValidator : AbstractValidator<PreRegisterRequest>
    {
        public PreRegistroRequestValidator() 
        {
            RuleFor(request => request.Email)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Email' é obrigatório")
                .EmailAddress().WithMessage(x => "Campo 'Email' não está no formato correto");
        }
    }
}
