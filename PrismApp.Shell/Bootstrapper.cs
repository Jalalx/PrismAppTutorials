using System;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Prism.Logging;

namespace PrismApp.Shell
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override ILoggerFacade CreateLogger()
        {
            return new TextFileLogger();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog()
            {
                ModulePath = Environment.CurrentDirectory
            };
        }

        protected override void ConfigureContainer()
        {
            // Register default core services
            base.ConfigureContainer();
            // Register Shell (main window)
            Container.RegisterType<MainWindow>();
        }

        protected override System.Windows.DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = (Window)this.Shell;
            Application.Current.MainWindow.Show();
        }
    }
}
