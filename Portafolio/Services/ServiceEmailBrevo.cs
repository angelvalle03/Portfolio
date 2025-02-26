using Portafolio.Models;
using SendWithBrevo;
using System.ComponentModel.DataAnnotations;

namespace Portafolio.Services
{
    
    public interface ISserviceEmail
    {

    }

    public class ServiceEmailBrevo : ISserviceEmail
    {
        private readonly IConfiguration configuration;
        public ServiceEmailBrevo(IConfiguration configuration)
        {

            this.configuration = configuration;
        }

        public async Task Send(ContactViewModel contact)
        {
            var apiKey = configuration.GetValue<string>("BREVO_API_KEY");
            var email = configuration.GetValue<string>("BREVO_FROM");
            var name = configuration.GetValue<string>("BREVO_NAME");



        }

    }
}
