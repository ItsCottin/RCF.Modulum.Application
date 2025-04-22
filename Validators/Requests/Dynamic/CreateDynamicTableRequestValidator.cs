using FluentValidation;
using modulum.Application.Requests.Dynamic.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Dynamic
{
    public class CreateDynamicTableRequestValidator : AbstractValidator<CreateDynamicTableRequest>
    {
        public CreateDynamicTableRequestValidator() 
        {
            RuleFor(request => request.CampoPK)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Campo PK' é obrigatório")
                .Must((model, campoPK) => model.Campos != null && model.Campos.Any(c => c.NomeCampoBase == campoPK))
                .WithMessage(x => "O Valor do campo 'Campo PK' não foi encontrado dentro do Objeto 'Campos'")
                .Must((model, campoPK) => model.Campos != null && model.Campos.Any(c => c.NomeCampoBase == campoPK && c.IsPrimaryKey == true))
                .WithMessage(x => "O campo informado em 'Campo PK' precisa estar marcado como chave primária nos campos adicionados.");
            RuleFor(request => request.NomeTela)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Nome da Tela' é obrigatório");
            RuleFor(x => x.Campos).Must(campos => campos != null && campos.Count(c => c.IsPrimaryKey) == 1)
                .WithMessage("Deve haver exatamente um campo com 'IsPrimaryKey' = true.");
            RuleFor(x => x.NomeTabela)
                .Matches("^[a-zA-Z0-9_]+$")
                .WithMessage("O nome da tabela deve conter apenas letras, números e underline."); // Impedir SQL Injection, precisa ser avaliado se é nescessario mais validações
        }
    }
}
