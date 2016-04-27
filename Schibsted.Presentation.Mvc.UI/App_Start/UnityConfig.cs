namespace Schibsted.Presentation.Mvc.UI
{
    using System.Web.Http.Controllers;
    using System.Web.Mvc;
    using Microsoft.Practices.Unity;
    using Schibsted.Crosscutting.Ioc.Builders;
    using Schibsted.Presentation.Mvc.UI.Controllers;
    using Schibsted.Presentation.Mvc.UI.Controllers.WebAPI;

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
            //RegisterControllers(container);

            App_Start.MvcUnityContainer.Container = container;

            Resolve(container);

            return container;
        }

        private static void RegisterControllers(IUnityContainer container)
        {
            container.RegisterType<IController, AccountController>(new ContainerControlledLifetimeManager());
            container.RegisterType<IController, HomeController>(new ContainerControlledLifetimeManager());
            container.RegisterType<IHttpController, ApiAccountController>(new ContainerControlledLifetimeManager());
        }

        private static void Resolve(IUnityContainer container)
        {
            container.Resolve<AccountController>();
            container.Resolve<HomeController>();
            container.Resolve<ApiAccountController>();
        }

    }

}