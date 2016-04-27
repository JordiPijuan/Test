namespace Schibsted.Crosscutting.Ioc.Builders
{
    using Infrastructure.Security.Contracts;
    using Infrastructure.Security.Providers;
    using Infrastructure.Security.Services;
    using Microsoft.Practices.Unity;

    public class SecurityBuilder
    {

        public static void RegisterServiceDependencies(IUnityContainer builder)
        {
            //builder
            //    //.RegisterType<AuthorizationService>(new PerResolveLifetimeManager())
            //    .RegisterType<IAuthorizeService, AuthorizationService>();
        }

        public static void RegisterProviderDependencies(IUnityContainer builder)
        {
            builder
                .RegisterType<SchibstedMembershipProvider>(new PerResolveLifetimeManager())
                .RegisterType<IAuthenticate, SchibstedMembershipProvider>()
                .RegisterType<IAuthorizate, SchibstedMembershipProvider>();
        }

    }

}
