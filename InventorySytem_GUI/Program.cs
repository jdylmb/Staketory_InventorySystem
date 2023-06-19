using System;
using System.Threading;
using System.Windows.Forms;

namespace InventorySytem_GUI
{
    internal static class Program
    {
        //private static WindowNavigator windowNavigator;
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
            //Application.Run(new Form2());

            // Initialize the window navigator and show the login form
           // windowNavigator = new WindowNavigator();
            WindowNavigator.ShowLoginForm();


            // show the splash screen
            Thread splashthread = new Thread(ShowSplashScreen);
            splashthread.Start();

            // simulate some initialization work
            SimulateInitializationWork();


            // close the splash screen when the initialization is complete
            if (splashScreen != null && !splashScreen.IsDisposed)
            {
               splashScreen.Invoke(new Action(() => splashScreen.Close()));
            }

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
        private static CreateUser createUserForm;
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

            if (createUserForm != null && !createUserForm.IsDisposed)
            {
                createUserForm.Close();
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

            if (createUserForm != null && !createUserForm.IsDisposed)
            {
                createUserForm.Close();
            }
        }

        public static void ShowCreateAccount()
        {
            if (createUserForm == null || createUserForm.IsDisposed)
            {
                createUserForm = new CreateUser();
            }

            createUserForm.Show();

            if (menuForm != null && !menuForm.IsDisposed)
            {
                menuForm.Close();
            }

            if (loginForm != null && !loginForm.IsDisposed)
            {
                loginForm.Close();
            }
        }

        // Add more methods as needed


    }


}
