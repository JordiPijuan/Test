namespace Schibsted.Infrastructure.Security.Providers
{
    using System;
    using Schibsted.Infrastructure.Security.Contracts;
    using Schibsted.Infrastructure.Repositories;
    using Services;
    public class SchibstedMembershipProvider : IAuthenticate, IAuthorizate, IDisposable
    {

        private readonly AuthorizationService _authorizateService;

        public SchibstedMembershipProvider() 
            : base()
        {
            _authorizateService = Activator.CreateInstance<AuthorizationService>();
            //_rolesService = Activator.CreateInstance<RolesRepository>();
        }

        public bool Authenticate(string username, string password)
        {
            return _authorizateService.Authenticate(username, password);
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
