using modulum.Application.Requests.Identity;
using FluentValidation;

namespace modulum.Application.Validators.Requests.Identity
{
    public class ForgotPasswordRequestValidator : AbstractValidator<ForgotPasswordRequest>
    {
        public ForgotPasswordRequestValidator()
        {
            RuleFor(request => request.Email)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Email' é obrigatório")
                .EmailAddress().WithMessage(x => "Campo 'Email' não está no formato correto");
        }
    }
}