using ImageStore.UI.Forms.Principal;
using static System.Windows.Forms.Application;

namespace ImageStore.Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Run(new FormPrincipal());
        }
    }
}