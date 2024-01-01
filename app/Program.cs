using System.Globalization;

namespace yhb_war3_custom_keys{
    internal static class Program {

        [STAThread]
        static void Main() {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;
            Application.Run(new FormMain());
        }
    }
}