namespace Schibsted.Presentation.Mvc.UI
{
    using Microsoft.Practices.Unity;
    using Schibsted.Crosscutting.Ioc.Builders;
    using Schibsted.Presentation.Mvc.UI.Controllers;

    public static class UnityConfig
    {

        public static IUnityContainer Initialize()
        {
            var container = BuildUnityContainer();

            return container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            AccesorsBuilder.RegisterAccesorsDependencies(container);
            BusinessBuilder.RegisterBusinessDependencies(container);

            App_Start.MvcUnityContainer.Container = container;
            Resolve(container);

            return container;
        }

        private static void Resolve(IUnityContainer container)
        {
            container.Resolve<AccountController>();
            container.Resolve<HomeController>();
        }

    }

}