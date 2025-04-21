using modulum.Application.Interfaces.Common;
using modulum.Application.Requests.Versao;
using modulum.Application.Responses.Versao;
using modulum.Shared.Wrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCF.Modulum.Application.Interfaces.Services
{
    public interface IVersao : IService
    {
        Task<IResult<List<VersaoResponse>>> GetAllVersao();

        Task<bool> AddEditPacotes(PackageListResultRequest request);
    }
}
