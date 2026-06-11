using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EaseStay.Core
{
    internal class Settings
    {
        public static string SMTP_HOST;
        public static int SMTP_PORT;
        public static string SMTP_USER;
        public static string SMTP_PASS;
        public static string DB_CONN;

        public static void LoadSettings()
        {
            SMTP_HOST = Properties.Settings.Default.SMTP_HOST;
            SMTP_PORT = Properties.Settings.Default.SMTP_PORT;
            SMTP_USER = Properties.Settings.Default.SMTP_USER;
            SMTP_PASS = Properties.Settings.Default.SMTP_PASS;
            DB_CONN = Properties.Settings.Default.DB_CONN;
        }

        public static void ConfigDatabase()
        {
            Database.Database db = new Database.Database(DB_CONN);

            if (db.Exists())
                return;

            db.EnsureCreated();

            db.Create("Users")
                .Column("UUID", "UNIQUEIDENTIFIER PRIMARY KEY NOT NULL DEFAULT NEWID()")
                .Column("Email", " VARCHAR(256) UNIQUE NOT NULL")
                .Column("EmailVerified", " BIT NOT NULL DEFAULT 0")
                .Column("FirstName", " VARCHAR(100) NOT NULL")
                .Column("LastName", " VARCHAR(100) NOT NULL")
                .Column("PasswordHash", " VARCHAR(60) NOT NULL")
                .Execute();
        }
    }
}
