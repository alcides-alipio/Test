using System.Net;
using System.Net.Mail;
using System.Text;
namespace EaseStay.Core.Services
{
    internal static class EmailService
    {
        static void Send(string subject, string body, string recipient)
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

        public static void SendRecoveryEmail(string recoverCode, string recipient)
        {
            var smtpClient = new SmtpClient(Settings.SMTP_HOST, Settings.SMTP_PORT)
            {
                Credentials = new NetworkCredential(Settings.SMTP_USER, Settings.SMTP_PASS),
                EnableSsl = true
            };

            string body = Properties.Resources.accountRecoveryEmailTemplate;
            body = body.Replace("{{RecoverCode}}", recoverCode);
            body = body.Replace("{{Email}}", MaskEmail(recipient));

            var mail = new MailMessage
            {
                From = new MailAddress(Settings.SMTP_USER),
                Subject = "Código de segurança da conta EaseStay",
                Body = body,
                IsBodyHtml = true,

                BodyEncoding = Encoding.UTF8,
                BodyTransferEncoding = System.Net.Mime.TransferEncoding.Base64,
                HeadersEncoding = Encoding.UTF8,
                SubjectEncoding = Encoding.UTF8
            };

            mail.To.Add(recipient);

            smtpClient.Send(mail);
        }

        public static string MaskEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return string.Empty;

            string[] emailParts = email.Split('@');
            string emailUsername = emailParts[0];
            string emailDomain = emailParts[1];

            string usernameStart = emailUsername.Substring(0, 2);
            string usernameEnd = emailUsername.Substring(emailUsername.Length - 1);

            return usernameStart + "**" + usernameEnd + "@" + emailDomain;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
