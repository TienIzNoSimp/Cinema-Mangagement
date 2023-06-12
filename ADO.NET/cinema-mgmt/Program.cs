using System;
using System.Windows.Forms;
using cinema_mgmt.Form_Admins;

namespace cinema_mgmt
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (new frmAdmins().ShowDialog() == DialogResult.OK)
                Application.Run(new frmMain());
        }
    }
}