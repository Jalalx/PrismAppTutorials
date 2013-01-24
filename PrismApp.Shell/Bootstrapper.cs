using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;

namespace PrismApp.Shell
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
            Container.RegisterType<MainWindow>();
        }

        protected override System.Windows.DependencyObject CreateShell()
        {
            var mainWindow = Container.Resolve<MainWindow>();
            mainWindow.Show();
            return mainWindow;
        }
    }
}
