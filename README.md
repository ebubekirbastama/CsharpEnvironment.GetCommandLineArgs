# CsharpEnvironment.GetCommandLineArgs
Bu Projede sizlere dışardan parametre alarak çalıştırabileceğimiz bir program örneğini gösterdim
<p>Program çalışırken "Environment.GetCommandLineArgs()" ile gelen parametreleri dizi halinde alıyoruz ve eğer "0123456789" yazısı geldiyese çalıştır diyoruz.<p>


<hr>

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
