using FluentValidation;
using modulum.Application.Requests.Account;
using modulum.Application.Requests.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Identity
{
    public class ConfirmaRegistroRequestValidator : AbstractValidator<TwoFactorRequest>
    {
        public ConfirmaRegistroRequestValidator()
        {
            RuleFor(request => request.Email)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Email' é obrigatório")
                .EmailAddress().WithMessage(x => "Campo 'Email' não está no formato correto");
            RuleFor(request => request.Code)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Codigo' é obrigatório")
                .Matches(@"^\d{6}$").WithMessage("Campo 'Código' deve conter exatamente 6 números");
        }
    }
}
