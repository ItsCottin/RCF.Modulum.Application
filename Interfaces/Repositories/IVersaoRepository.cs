using modulum.Application.Requests.Versao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Repositories
{
    public interface IVersaoRepository
    {
        Task<bool> Update(string? versao, PackageListResultRequest request);
    }
}
