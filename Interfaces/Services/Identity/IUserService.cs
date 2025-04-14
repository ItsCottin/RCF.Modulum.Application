using modulum.Application.Interfaces.Common;
using modulum.Application.Requests.Account;
using modulum.Application.Requests.Identity;
using modulum.Application.Responses.Identity;
using modulum.Shared.Wrapper;
using nodulum.Application.Requests.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Services.Identity
{
    public interface IUserService : IService
    {
        Task<Result<List<UserResponse>>> GetAllAsync();

        Task<IResult> FimRegisterAsync(FinishRegisterRequest request, string origin);

        Task<IResult> PreRegisterAsync(PreRegisterRequest request, string origin);

        Task<IResult<UserResponse>> GetAsync(int userId);

        Task<IResult> ForgotPasswordAsync(ForgotPasswordRequest request, string origin);

        Task<IResult> ResetPasswordAsync(ResetPasswordRequest request);

        Task<int> GetCountAsync();

        Task<IResult> ConfirmEmailAsync(TwoFactorRequest request);

        Task<IResult> IsEmailConfirmed(string email);

        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);
    }
}