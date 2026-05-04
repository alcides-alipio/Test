using System.Net;
using System.Net.Mail;

namespace EaseStay.Core.Services
{
    internal class EmailService
    {
        public static void Send(string subject, string body, string recipient)
        {

            var smtpClient = new SmtpClient(Settings.SMTP_HOST, Settings.SMTP_PORT)
            {
                Credentials = new NetworkCredential(Settings.SMTP_USER, Settings.SMTP_PASS),
                EnableSsl = true
            };

            var mail = new MailMessage
            {
                From = new MailAddress(Settings.SMTP_USER),
                Subject = subject,
                Body = body,
                IsBodyHtml = false
            };

            mail.To.Add(recipient);

            smtpClient.Send(mail);
        }
    }
}
