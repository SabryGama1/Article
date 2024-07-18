using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Article.Code
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("sabrygamal976@gmail.com", "password"),
                EnableSsl = true,
            };
            return smtpClient.SendMailAsync("sabrygamal976@gmail.com", email, subject, htmlMessage);
        }
    }
}
