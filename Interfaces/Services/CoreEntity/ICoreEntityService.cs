using modulum.Application.Interfaces.Common;
using modulum.Domain.Entities.MapCoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCF.Modulum.Application.Interfaces.Services.CoreEntity
{
    public interface ICoreEntityService : IService
    {
        Task<int> CriarTabelaAsync(Table table);
    }
}
