using System;
using System.Drawing;

namespace ManagementApp
{
    public class Global
    {
        public static MyUser currentUser = new MyUser();
        public static string conStr = Program.ConnectionString;
        public static DateTime loginTime = new DateTime();
        public static DateTime logoutTime = new DateTime();

        //panel colors
        public static Color red = Color.FromArgb(255, 242, 240);
        public static Color green = Color.FromArgb(239, 255, 239);
        public static Color yellow = Color.FromArgb(255, 255, 230);

        //

        public static Font UniversalFont = new Font(new FontFamily("Microsoft Sans Serif"), 10.25f, FontStyle.Regular);

    }
}
