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
    }
}
