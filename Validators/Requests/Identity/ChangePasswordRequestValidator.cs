using modulum.Application.Requests.Identity;
using FluentValidation;

namespace modulum.Application.Validators.Requests.Identity
{
    public class ChangePasswordRequestValidator : AbstractValidator<ChangePasswordRequest>
    {
        public ChangePasswordRequestValidator()
        {
            RuleFor(request => request.Password)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "A Senha Atual é obrigatório");
            RuleFor(request => request.NewPassword)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Senha' é obrigatório")
                .MinimumLength(8).WithMessage("A senha deve ter pelo menos 8 caracteres")
                .Matches(@"[A-Z]").WithMessage("A senha deve conter pelo menos uma letra maiúscula")
                .Matches(@"[a-z]").WithMessage("A senha deve conter pelo menos uma letra minúscula")
                .Matches(@"[0-9]").WithMessage("A senha deve conter pelo menos um número");
            RuleFor(request => request.ConfirmNewPassword)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Confirme sua Senha' é obrigatório")
                .Equal(request => request.NewPassword).WithMessage(x => "Os campos 'Senha' e 'Confirme sua Senha' devem ser iguais");
        }
    }
}