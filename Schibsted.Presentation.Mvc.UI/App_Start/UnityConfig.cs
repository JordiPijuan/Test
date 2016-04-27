namespace Schibsted.Presentation.Mvc.UI
{
    using System.Web.Http.Controllers;
    using System.Web.Mvc;
    using Microsoft.Practices.Unity;
    using Crosscutting.Ioc.Builders;
    using Controllers;
    using Controllers.WebAPI;

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
            SecurityBuilder.RegisterServiceDependencies(container);
            SecurityBuilder.RegisterProviderDependencies(container);

            App_Start.MvcUnityContainer.Container = container;

            Resolve(container);

            return container;
        }

        private static void Resolve(IUnityContainer container)
        {
            container.Resolve<AccountController>();
            container.Resolve<HomeController>();
            container.Resolve<ApiAccountController>();
        }

    }

}