using FluentValidation;
using modulum.Application.Requests.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Identity
{
    public class CadastroExternoRequestValidator : AbstractValidator<CadastroExternoRequest>
    {
        public CadastroExternoRequestValidator()
        {
            RuleFor(x => x.Cpf)
                .NotEmpty()
                .WithMessage("O Campo 'CPF' é Obrigatório")
                .Must(CpfValido).WithMessage("O CPF informado é inválido");
            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("O Campo 'E-Mail' é Obrigatório")
                .EmailAddress()
                .WithMessage("O Campo 'E-Mail' deve ser um endereço de e-mail válido")
                .Matches(@"^[a-zA-Z0-9._+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$").WithMessage("Campo 'Email' contem caracteres não permitidos");
            RuleFor(x => x.Password)
                .NotEmpty()
                .WithMessage("O Campo 'Password' é Obrigatório");
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("O Campo 'Name' é Obrigatório");
        }

        private bool CpfValido(string cpf)
        {
            if (string.IsNullOrWhiteSpace(cpf))
                return false;

            cpf = Regex.Replace(cpf, "[^0-9]", ""); // remove pontuação

            if (cpf.Length != 11 || new string(cpf[0], 11) == cpf)
                return false;

            var multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            var multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            var tempCpf = cpf.Substring(0, 9);
            var soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            var resto = soma % 11;
            var digito1 = resto < 2 ? 0 : 11 - resto;

            tempCpf += digito1;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            var digito2 = resto < 2 ? 0 : 11 - resto;

            return cpf.EndsWith($"{digito1}{digito2}");
        }

    }
}
