using modulum.Application.Interfaces.Common;

namespace modulum.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}