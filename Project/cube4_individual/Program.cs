using System;
using System.Windows.Forms;

namespace CompanyDirectoryApp
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); // Replace `MainForm` with `AdminDashboardForm` for testing the admin interface
        }
    }
}
