namespace Schibsted.Crosscutting.Ioc.Builders
{
    using Microsoft.Practices.Unity;
    using Schibsted.Business.Contracts;
    using Schibsted.Business.Core;

    public class BusinessBuilder
    {

        public static void RegisterBusinessDependencies(IUnityContainer builder)
        {
            builder
                .RegisterType<IRepositoryService, RepositoryService>(new ContainerControlledLifetimeManager());
        }

    }

}

