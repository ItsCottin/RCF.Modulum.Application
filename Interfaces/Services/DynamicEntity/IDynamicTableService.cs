using modulum.Application.Interfaces.Common;
using modulum.Application.Requests.Dynamic;
using modulum.Domain.Entities.DynamicEntity;
using modulum.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Services.DynamicEntity
{
    public interface IDynamicTableService : IService
    {
        //Task<IResult> CriarTabelaFisicaAsync(Table table);

        Task<IResult> InsertAsync(DynamicTableRequest request);

        Task<IResult> UpdateAsync(DynamicTableRequest request);

        Task<IResult> DeletePorIdAsync(DynamicForIdRequest request);

        Task<IResult<DynamicTableRequest>> ConsultaTodosPorIdTabelaAsync(int idTabela);

        Task<IResult<DynamicTableRequest>> ConsultaRegistroPorIdTabelaEIdRegistroAsync(DynamicForIdRequest request);

        Task<IResult<List<MenuRequest>>> GetMenu();

        Task<IResult<DynamicTableRequest>> GetNewObjetoDinamico(int idTabela);
    }
}
