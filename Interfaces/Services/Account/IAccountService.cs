using modulum.Application.Interfaces.Common;
using modulum.Application.Requests.Identity;
using modulum.Shared.Wrapper;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Services.Account
{
    public interface IAccountService : IService
    {
        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);
    }
}