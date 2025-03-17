using modulum.Application.Requests.Mail;
using System.Threading.Tasks;

namespace modulum.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}