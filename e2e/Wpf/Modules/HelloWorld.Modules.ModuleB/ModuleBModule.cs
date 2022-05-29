using System.Diagnostics;

using HelloWorld.Modules.ModuleB.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace HelloWorld.Modules.ModuleB
{
    public class ModuleBModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Debug.WriteLine("5-2-1. ModuleB.RegisterTypes");
            containerRegistry.RegisterForNavigation<ViewB>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Debug.WriteLine("5-2-2. ModuleB.OnInitialized");
        }
    }
}
