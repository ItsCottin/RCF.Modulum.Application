using FluentValidation;
using modulum.Application.Requests.Dynamic.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Dynamic
{
    public class RenameNomeTabelaTelaRequestValidator : AbstractValidator<RenameNomeTabelaTelaRequest>
    {
        public RenameNomeTabelaTelaRequestValidator()
        { 
            RuleFor(request => request.IdTabela).NotNull().NotEmpty().WithMessage("O campo 'IdTabela' é obrigatório");
            RuleFor(request => request.NovoNome).NotNull().NotEmpty().WithMessage("O campo 'NovoNome' é obrigatório");
            RuleFor(c => c.NovoNome).Matches("^[a-zA-Z0-9_ ]+$").WithMessage("O nome do 'NovoNome' deve conter apenas letras, números e underline.");
        }
    }
}
