using FluentValidation;
using modulum.Application.Requests.Dynamic;
using modulum.Application.Requests.Dynamic.Create;
using modulum.Application.Requests.Dynamic.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Dynamic
{
    public class UpdateDynamicTableRequestValidator : AbstractValidator<UpdateDynamicTableRequest>
    {
        public UpdateDynamicTableRequestValidator() 
        {
            RuleFor(request => request.Id).NotNull().WithMessage(x => "Campo 'Id' do objeto é obrigatório");
            RuleFor(x => x.Campos).Must(campos => campos != null && campos.Count() >= 2)
                .WithMessage("É nescessário pelo menos 2 campos para cadastrar");
            RuleFor(request => request.NomeTela)
                .Must(x => !string.IsNullOrWhiteSpace(x)).WithMessage(x => "Campo 'Nome da Tela' é obrigatório");
            RuleFor(x => x.NomeTabela)
                .Matches("^[a-zA-Z0-9_]+$")
                .WithMessage("O nome da tabela deve conter apenas letras, números e underline."); // Impedir SQL Injection, precisa ser avaliado se é nescessario mais validações
            RuleFor(x => x.NomeTela)
                .Matches("^[a-zA-Z0-9_ ]+$")
                .WithMessage("O nome da tela deve conter apenas letras, números e underline."); // Impedir SQL Injection, precisa ser avaliado se é nescessario mais validações
            //RuleForEach(x => x.Campos).SetValidator(new CreateDynamicFieldRequestValidator());
            RuleForEach(x => x.Campos).SetInheritanceValidator(v =>
            {
                v.Add<UpdateDynamicFieldRequest>(new UpdateDynamicFieldRequestValidator());
            });
        }
    }
}
