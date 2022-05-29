using HelloWorld.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;

using System.Diagnostics;
using System.Windows;
using Unity;

namespace HelloWorld
{
    class Bootstrapper : PrismBootstrapper
    {
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            Debug.WriteLine("1. RegisterTypes");
            containerRegistry.RegisterSharedSamples();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            Debug.WriteLine("2. ConfigureModuleCatalog");
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<HelloWorld.Modules.ModuleA.ModuleAModule>();
            moduleCatalog.AddModule<HelloWorld.Modules.ModuleB.ModuleBModule>();
        }

        protected override DependencyObject CreateShell()
        {
            Debug.WriteLine("3. CreateShell");
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell(DependencyObject shell)
        {
            Debug.WriteLine("4. InitializeShell");
            Shell = shell;
        }

        /// <summary>
        /// Initializes the modules.
        /// </summary>
        protected override void InitializeModules()
        {
            Debug.WriteLine("5. InitializeModules");
            base.InitializeModules();
            // PrismInitializationExtensions.RunModuleManager(Container);
        }

        /// <summary>
        /// Contains actions that should occur last.
        /// </summary>
        protected override void OnInitialized()
        {
            Debug.WriteLine("6. OnInitialized");
            if (Shell is Window window)
                window.Show();
        }
    }
}
