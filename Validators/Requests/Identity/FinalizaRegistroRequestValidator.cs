using FluentValidation;
using modulum.Application.Requests.Account;
using nodulum.Application.Requests.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Identity
{
    public class FinalizaRegistroRequestValidator : AbstractValidator<FinishRegisterRequest>
    {
        public FinalizaRegistroRequestValidator() 
        {
            RuleFor(request => request.Email)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Email' é obrigatório")
                .EmailAddress().WithMessage(x => "Campo 'Email' não está no formato correto");
            RuleFor(request => request.Password)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Senha' é obrigatório")
                .MinimumLength(8).WithMessage("A senha deve ter pelo menos 8 caracteres")
                .Matches(@"[A-Z]").WithMessage("A senha deve conter pelo menos uma letra maiúscula")
                .Matches(@"[a-z]").WithMessage("A senha deve conter pelo menos uma letra minúscula")
                .Matches(@"[0-9]").WithMessage("A senha deve conter pelo menos um número");
            RuleFor(request => request.ConfirmPassword)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Confirme sua Senha' é obrigatório")
                .Equal(request => request.Password).WithMessage(x => "Os campos 'Senha' e 'Confirme sua Senha' devem ser iguais");
        }
    }
}
