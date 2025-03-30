using modulum.Application.Requests.Identity;
using FluentValidation;

namespace modulum.Application.Validators.Requests.Identity
{
    public class TokenRequestValidator : AbstractValidator<TokenRequest>
    {
        public TokenRequestValidator()
        {
            RuleFor(request => request.Email)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Email' é obrigatório")
                .EmailAddress().WithMessage(x => "Campo 'Email' não está no formato correto");
            RuleFor(request => request.Password)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Senha' é obrigatório");
        }
    }
}
