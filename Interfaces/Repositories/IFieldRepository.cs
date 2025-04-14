using modulum.Domain.Entities.DynamicEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Repositories
{
    public interface IFieldRepository
    {
        Task AddField(Field field);
        Task GetFieldById(int id);
        Task DeleteField(Field field);
        Task UpdateField(Field field);
    }
}
