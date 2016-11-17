using System.Net;
using System.Net.Mail;
using BdayGreetingsKata.Domain.Entities;

namespace BdayGreetingsKata.Data.Messaging.Internet
{
    internal class EmailMessagingService : IMessagingService
    {
        public void SendMessageTo(Employee dest, string msg)
        {
            var message = new MailMessage("birthday@contoso.com", dest.Email)
            {
                Subject = "Happy birthday!",
                Body = msg
            };

            var client = new SmtpClient
            {
                Port = 25,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Host = "smtp.live.com",
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("live@email", "livepassword")
            };

            client.Send(message);
        }
    }
}
