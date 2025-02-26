using Portafolio.Models;
using Resend;

namespace Portafolio.Services
{

    public interface ISserviceEmailR
    {
        Task Execute(ContactViewModel contact);
    }


    public class ServiceEmailResend : ISserviceEmailR
    {
        private readonly IResend _resend;


        public ServiceEmailResend(IResend resend)
        {
            _resend = resend;
        }


        public async Task Execute(ContactViewModel contact)
        {
            var message = new EmailMessage();
            message.From = contact.Email;
            message.To.Add("angelvalle172@gmail.com");
            message.Subject = "hello world";
            message.HtmlBody = "<strong>it works!</strong><p>" + contact.Message + "</p>";

            await _resend.EmailSendAsync(message);
        }


    }
}
