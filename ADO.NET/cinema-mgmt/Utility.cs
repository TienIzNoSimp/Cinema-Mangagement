using System.Windows.Forms;
using cinema_mgmt.Properties;

namespace cinema_mgmt
{
    internal class Utility
    {
        internal static string connStr = Settings.Default.connStr;

        internal static void Notification(string message)
        {
            MessageBox.Show(message, @"Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal static void Error(string message)
        {
            MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        internal static DialogResult Confirm(string message)
        {
            return MessageBox.Show(message, @"Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}