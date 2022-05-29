using System.Diagnostics;

using HelloWorld.Modules.ModuleA.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace HelloWorld.Modules.ModuleA
{
    public class ModuleAModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Debug.WriteLine("5-1-1. ModuleA.RegisterTypes");
            containerRegistry.RegisterForNavigation<ViewA>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Debug.WriteLine("5-1-2. ModuleA.OnInitialized");
        }
    }
}
