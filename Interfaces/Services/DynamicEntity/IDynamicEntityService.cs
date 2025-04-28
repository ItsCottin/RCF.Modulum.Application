using modulum.Application.Interfaces.Common;
using modulum.Application.Requests.Dynamic.Create;
using modulum.Domain.Entities.DynamicEntity;
using modulum.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Services.DynamicEntity
{
    public interface IDynamicEntityService : IService
    {
        Task<IResult<Table>> CriarMapTabelaAsync(CreateDynamicTableRequest request);
        Task<IResult<Table>> ConsultarMapTabelaAsync(int tableId);
    }
}
