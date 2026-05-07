using DotNetEnv;
using System;

namespace EaseStay.Core
{
    internal class Settings
    {
        public static Guid UserUUID;

        public static string SMTP_HOST;
        public static int SMTP_PORT;
        public static string SMTP_USER;
        public static string SMTP_PASS;
        public static string DB_CONN;

        public static void LoadSettings()
        {
            Env.Load();

            SMTP_HOST = Environment.GetEnvironmentVariable("SMTP_HOST");
            SMTP_PORT = int.Parse(Environment.GetEnvironmentVariable("SMTP_PORT"));
            SMTP_USER = Environment.GetEnvironmentVariable("SMTP_USER");
            SMTP_PASS = Environment.GetEnvironmentVariable("SMTP_PASS");
            DB_CONN = Environment.GetEnvironmentVariable("DB_CONN");
        }
    }
}
