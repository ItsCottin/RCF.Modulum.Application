using modulum.Application.Interfaces.Common;
using modulum.Application.Requests.Mail;

namespace modulum.Application.Interfaces.Services.Account
{
    public interface IEmailService : IService
    {
        Task<string> SendEmail(MailRequest request);
    }
}
