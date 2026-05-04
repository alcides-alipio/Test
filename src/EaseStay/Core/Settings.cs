using DotNetEnv;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaseStay.Core
{
    internal class Settings
    {
        public static Guid UserUUID;

        public static string SmtpEmailAddress;
        public static string SmtpEmailPassword;

        public static void LoadSettings()
        {
            Env.Load();

            SmtpEmailAddress = Environment.GetEnvironmentVariable("SMTP_EMAIL_ADDRESS");
            SmtpEmailPassword = Environment.GetEnvironmentVariable("SMTP_EMAIL_PASSWORD");
        }
    }
}
