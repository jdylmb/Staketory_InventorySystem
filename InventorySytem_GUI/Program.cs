using System;
using System.Threading;
using System.Windows.Forms;

namespace InventorySytem_GUI
{
    internal static class Program
    {
        private static WindowNavigator windowNavigator;
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
            //windowNavigator = new WindowNavigator();
            //windowNavigator.ShowLoginForm();

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
            Application.Run(new Menu());
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

    internal class WindowNavigator
    {
        private Menu menuForm;
        private LogInForm loginForm;
        // Add more form instances as needed

        public WindowNavigator()
        {
            // Initialize form instances
            menuForm = new Menu();
            loginForm = new LogInForm();
            // Initialize more forms as needed
        }

        public void ShowMenu()
        {
            menuForm.Show();
            loginForm.Close();
        }

        public void ShowLoginForm()
        {
            loginForm.Show();
            menuForm.Close();
        }

        // Add more methods to show other forms as needed
    }
}
