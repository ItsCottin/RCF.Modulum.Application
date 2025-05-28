using MediatR;
using modulum.Application.Interfaces.Common;
using modulum.Application.Requests.Dynamic;
using modulum.Application.Requests.Dynamic.Create;
using modulum.Application.Requests.Dynamic.Relationship;
using modulum.Application.Requests.Dynamic.Update;
using modulum.Application.Responses.Dynamic;
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
        Task<IResult> CriarMapTabelaAsync(CreateDynamicTableRequest request);
        Task<IResult<CreateDynamicTableRequest>> ConsultarMapTabelaAsync(int tableId);
        Task<IResult> RenameNomeTabelaTelaAsync(RenameNomeTabelaTelaRequest request);
        Task<IResult> AlterMapTableAsync(CreateDynamicTableRequest request);
        Task<IResult> DeleteMapTableAsync(int tableId);
        Task<IResult> AlterRelacionamento(List<CreateDynamicRelationshipRequest> request);
        Task<IResult<List<CreateDynamicRelationshipRequest>>> ConsultarRelacionamento(int tableId);
        Task<IResult> DeletarRelacionamento(DynamicForIdRequest request);
    }
}
