using System.Diagnostics;

namespace _2P_DP_PatyLopez
{
    public static class Program
    {

        public static User LoggedUser;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.Run(new LoginForm());
        }
    }
}