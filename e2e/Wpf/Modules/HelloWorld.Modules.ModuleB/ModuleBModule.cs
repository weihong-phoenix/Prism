using System.Diagnostics;

using HelloWorld.Modules.ModuleB.Views;
using Prism.Ioc;
using Prism.Modularity;

using HelloWorld.Modules.ModuleA.Views;
using HelloWorld.Modules.ModuleA.ViewModels;

namespace HelloWorld.Modules.ModuleB
{
    public class ModuleBModule : IModule
    {
        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Debug.WriteLine("5-2-1. ModuleB.RegisterTypes");
            containerRegistry.RegisterForNavigation<ViewB>();

            containerRegistry.RegisterDialog<MyDialog, MyDialogViewModel>();
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            Debug.WriteLine("5-2-2. ModuleB.OnInitialized");
        }
    }
}
