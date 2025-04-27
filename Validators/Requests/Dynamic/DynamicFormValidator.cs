using FluentValidation;
using modulum.Application.Models;
using modulum.Application.Requests.Dynamic.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Validators.Requests.Dynamic
{
    public class DynamicFormValidator : AbstractValidator<DynamicForm>
    {
        public DynamicFormValidator() 
        {
            RuleFor(r => r.fieldRequest).SetValidator(new CreateDynamicFieldRequestValidator());
            RuleFor(r => r.tableRequest).SetValidator(new CreateDynamicTableRequestValidator());

            RuleFor(x => x.fieldRequest).SetInheritanceValidator(v =>
            {
                v.Add<CreateDynamicFieldRequest>(new CreateDynamicFieldRequestValidator());
            });

            RuleFor(x => x.tableRequest).SetInheritanceValidator(v =>
            {
                v.Add<CreateDynamicTableRequest>(new CreateDynamicTableRequestValidator());
            });
        }
    }
}
