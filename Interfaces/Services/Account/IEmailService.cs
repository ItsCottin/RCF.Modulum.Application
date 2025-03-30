using modulum.Application.Requests.Mail;

namespace modulum.Application.Interfaces.Services.Account
{
    public interface IEmailService
    {
        Task<string> SendEmail(MailRequest request);
    }
}
