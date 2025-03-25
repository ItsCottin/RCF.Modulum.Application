using modulum.Application.Requests.Identity;
using FluentValidation;

namespace modulum.Application.Validators.Requests.Identity
{
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(request => request.NomeCompleto)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Nome Completo é obrigatório");
            RuleFor(request => request.Email)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Email é obrigatório")
                .EmailAddress().WithMessage(x => "Email não está no formato correto");
            RuleFor(request => request.UserName)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "UserName é obrigatório")
                .MinimumLength(6).WithMessage("UserName must be at least of length 6");
            RuleFor(request => request.Password)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Password is required!")
                .MinimumLength(8).WithMessage("Password must be at least of length 8")
                .Matches(@"[A-Z]").WithMessage("Password must contain at least one capital letter")
                .Matches(@"[a-z]").WithMessage("Password must contain at least one lowercase letter")
                .Matches(@"[0-9]").WithMessage("Password must contain at least one digit");
            RuleFor(request => request.ConfirmPassword)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Password Confirmation is required!")
                .Equal(request => request.Password).WithMessage(x => "Passwords don't match");
        }
    }
}