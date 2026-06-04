using System.Windows.Forms;

namespace EaseStay.Core.UI.Dialogs
{
    internal static class MessageDialog
    {
        public static void Error(string message, string title)
        {
            MessageBox.Show(
                message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Error );
        }

        internal static void Success(string message, string title)
        {
            MessageBox.Show(
                message, title,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
