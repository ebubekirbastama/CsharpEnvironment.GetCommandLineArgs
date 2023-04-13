namespace DesktopEğitim_SEti
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();
            if (args[1] == "0123456789")
            {

                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }

        }
    }
}