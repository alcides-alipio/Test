using System.Windows.Forms;

namespace EaseStay.Core.UI.Extensions
{
    internal static class TagExtension
    {
        public static string GetTagValue(this Control control, string key)
        {
            string tagData = control.Tag.ToString().Trim();

            if (string.IsNullOrEmpty(tagData))
                return string.Empty;

            foreach (string item in tagData.Split(';'))
            {
                string[] keyValue = item.Split('=');
               
                if (key == keyValue[0])
                    return keyValue[1];
            }

            return string.Empty;
        }
    }
}