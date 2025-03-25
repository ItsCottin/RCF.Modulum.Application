using modulum.Application.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCF.Modulum.Application.Interfaces.Services.CoreEntity
{
    public interface IDynamicTableService : IService
    {
        Task CriarTabelaFisicaAsync(int tableId);
    }
}
