using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration.Provider;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using Schibsted.Business.Contracts;
using Schibsted.Business.Core;
using Schibsted.Crosscutting.Entities;
using Schibsted.Crosscutting.Security.Contracts;
using Schibsted.DataAccess.Contracts;
using Schibsted.DataAccess.Repositories;

namespace Schibsted.Crosscutting.Security
{

    public class SchibstedMembershipProvider : IAuthenticate, IAuthorizate, IDisposable
    {

        private readonly UserRepository _usersService;
        private readonly RolesRepository _rolesService;

        public SchibstedMembershipProvider() 
            : base()
        {
            _usersService = Activator.CreateInstance<UserRepository>();
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
