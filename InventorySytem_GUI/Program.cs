using System;
using System.Threading;
using System.Windows.Forms;

namespace InventorySytem_GUI
{
    internal static class Program
    {
        private static Start splashScreen;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //// Initialize the window navigator and show the login form
            WindowNavigator.ShowLoginForm();

            //// Show the splash screen
            //Thread splashThread = new Thread(ShowSplashScreen);
            //splashThread.Start();

            //// Simulate some initialization work
            //SimulateInitializationWork();


            //// Close the splash screen when the initialization is complete
            //if (splashScreen != null && !splashScreen.IsDisposed)
            //{
            //    splashScreen.Invoke(new Action(() => splashScreen.Close()));
            //}

            // Run the application
            Application.Run();
        }

        private static void ShowSplashScreen()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            splashScreen = new Start();
            Application.Run(splashScreen);
        }


        private static void SimulateInitializationWork()
        {
            // Simulate some initialization work here
            Thread.Sleep(10000);
        }
    }

    public static class WindowNavigator
    {
        private static Menu menuForm;
        private static LogInForm loginForm;
        // Add more form instances as needed

        public static void ShowMenu()
        {
            if (menuForm == null || menuForm.IsDisposed)
            {
                menuForm = new Menu();
            }

            menuForm.Show();

            if (loginForm != null && !loginForm.IsDisposed)
            {
                loginForm.Close();
            }
        }

        public static void ShowLoginForm()
        {
            if (loginForm == null || loginForm.IsDisposed)
            {
                loginForm = new LogInForm();
            }

            loginForm.Show();

            if (menuForm != null && !menuForm.IsDisposed)
            {
                menuForm.Close();
            }
        }

        // Add more methods as needed


    }


}
