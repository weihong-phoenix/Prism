using System.Diagnostics;

using HelloWorld.Modules.ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace HelloWorld.Modules.ModuleA
{
    public class ModuleAModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Debug.WriteLine("6-1-1. ModuleA.RegisterTypes");
            // containerRegistry.RegisterForNavigation<ViewA>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Debug.WriteLine("6-1-2. ModuleA.OnInitialized");
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }
    }
}
