using BlApi;

namespace UI
{
    internal static class Program
    {
        //static readonly IBL s_bl = Factory.Get();

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainMenu());

        }
    }
}