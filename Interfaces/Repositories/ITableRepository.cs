using modulum.Domain.Entities.DynamicEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Repositories
{
    public interface ITableRepository
    {
        Task AddTable(Table table);
        Task GetTableById(int id);
        Task DeleteTable(Table table);
        Task UpdateTable(Table table);
        Task<Table?> GetTableByName(string name);
    }
}
