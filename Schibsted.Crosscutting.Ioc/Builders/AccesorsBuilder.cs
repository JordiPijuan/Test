namespace Schibsted.Infrastructure.Ioc.Builders
{
    using Microsoft.Practices.Unity;
    using Schibsted.Infrastructure.Entities;
    using Schibsted.Infrastructure.Contracts;
    using Schibsted.Infrastructure.Repositories;

    public class AccesorsBuilder
    {

        public static void RegisterAccesorsDependencies(IUnityContainer builder)
        {
            builder
                .RegisterType<IUsersRepository<User>, UsersRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IRolesRepository<Role>, RolesRepository>(new ContainerControlledLifetimeManager())
                .RegisterType<IUserRepository<User>, UserRepository>(new ContainerControlledLifetimeManager());
        }

    }

}
