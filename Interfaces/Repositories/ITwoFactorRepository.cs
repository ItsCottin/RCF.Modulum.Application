using modulum.Domain.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Repositories
{
    public interface ITwoFactorRepository
    {
        Task<TwoFactor> GetTwoFactorByUserId(int userId);

        Task UpdateTwoFactor(TwoFactor twoFactor);
    }
}
