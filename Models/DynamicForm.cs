using modulum.Application.Requests.Dynamic.Create;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Models
{
    public class DynamicForm
    {
        public CreateDynamicTableRequest tableRequest;
        public CreateDynamicFieldRequest fieldRequest;
        public DynamicForm()
        {
            tableRequest = new CreateDynamicTableRequest();
            fieldRequest = new CreateDynamicFieldRequest();
        }
    }
}
