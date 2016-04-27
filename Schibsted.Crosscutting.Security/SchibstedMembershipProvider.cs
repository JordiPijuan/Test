namespace Schibsted.Infrastructure.Security
{
    using System;
    using Schibsted.Infrastructure.Security.Contracts;
    using Schibsted.Infrastructure.Repositories;

    public class SchibstedMembershipProvider : IAuthenticate, IAuthorizate, IDisposable
    {

        private readonly UsersRepository _usersService;
        private readonly RolesRepository _rolesService;

        public SchibstedMembershipProvider() 
            : base()
        {
            _usersService = Activator.CreateInstance<UsersRepository>();
            _rolesService = Activator.CreateInstance<RolesRepository>();
        }

        public bool Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }

        public ISchibstedIdentity Authorize(string username)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }

}
