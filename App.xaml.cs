using MyCalc.App_Start;
using System.Windows;

namespace MyCalc
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            new Bootstrapper().Run();
        }
    }
}
