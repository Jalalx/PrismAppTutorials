using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using PrismApp.Modules.MyFirstModule.Services;
using PrismApp.Modules.MyFirstModule.ViewModels;
using PrismApp.Modules.MyFirstModule.Views;
using System;

namespace PrismApp.Modules.MyFirstModule
{
    public class MyFirstModule : IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;

        public MyFirstModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            // Register Services
            _container.RegisterType<INameService, NameService>();

            // Register ViewModels
            _container.RegisterType<MyModuleMainViewModel>();

            //Register Views
            _container.RegisterType<Object, MyModuleMainView>();
            _container.RegisterType<Object, MyModuleRibbonTab>();

            // Register views inside named regions
            _regionManager.RegisterViewWithRegion("RibbonRegion", ResolveRibbonTabView);
            _regionManager.RegisterViewWithRegion("MainRegion", ResolveMainView);
        }

        private object ResolveRibbonTabView()
        {
            return _container.Resolve<MyModuleRibbonTab>();
        }

        private object ResolveMainView()
        {
            return _container.Resolve<MyModuleMainView>();
        }
    }
}
