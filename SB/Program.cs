namespace SB
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
            UI form1 = new UI();
            ControlUI form2 = new ControlUI();

            // Show both forms
            form1.Show();
            form2.Show();
            Application.Run();
           // Application.Run(new ControlUI());
        }
    }
}