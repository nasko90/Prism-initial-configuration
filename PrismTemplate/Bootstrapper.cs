using Microsoft.Practices.Unity;
using Prism.Unity;
using PrismTemplate.Views;
using System;
using System.Windows;

namespace PrismTemplate
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.TryResolve<AppWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();
        
            Container.RegisterType<AutomationManager>(new InjectionConstructor("Valio"));
            Container.RegisterType<IAutomationManager, AutomationManager>(new ContainerControlledLifetimeManager());
            Container.RegisterTypeForNavigation<Tisho>("Tisho");
            Container.RegisterTypeForNavigation<Pesa>("Pesa");
        }
    }
}
