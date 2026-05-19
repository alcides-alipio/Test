using CredentialManagement;
using DotNetEnv;
using System;

namespace EaseStay.Core
{
    internal class Settings
    {
        public static Guid UserUUID;
        public static string UserEmail;
        public static string UserFirstName;
        public static string UserLastName;


        public static string SMTP_HOST;
        public static int SMTP_PORT;
        public static string SMTP_USER;
        public static string SMTP_PASS;
        public static string DB_CONN;

        public static void LoadSettings()
        {
            Env.Load();

            SMTP_HOST = Properties.Settings.Default.SMTP_HOST;
            SMTP_PORT = Properties.Settings.Default.SMTP_PORT;
            SMTP_USER = Properties.Settings.Default.SMTP_USER;
            SMTP_PASS = Properties.Settings.Default.SMTP_PASS;
            DB_CONN = Properties.Settings.Default.DB_CONN;
        }

        public static void SavePersistentSession(Guid uuid)
        {
            var cred = new Credential
            {
                Target = "EaseStay_Login_Persistent",
                Username = uuid.ToString(),
                PersistanceType = PersistanceType.LocalComputer
            };

            cred.Save();
        }

        public static Guid GetPersistentSession()
        {
            var cred = new Credential { Target = "EaseStay_Login_Persistent" };

            if (!cred.Load())
                return Guid.Empty;

            if (Guid.TryParse(cred.Username, out Guid uuid))
                return uuid;

            return Guid.Empty;
        }

        public static void DeletePersistentSession()
        {
            var cred = new Credential { Target = "EaseStay_Login_Persistent" };

            cred.Delete();
        }
    }
}
