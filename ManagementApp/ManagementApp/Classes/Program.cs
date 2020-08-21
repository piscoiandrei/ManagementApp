using System;
using System.Windows.Forms;

namespace ManagementApp
{
    static class Program
    {
        public static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='" + System.IO.Path.GetFullPath("../../database.mdf") + "';Integrated Security=True;Connect Timeout=30";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
