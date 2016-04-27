namespace Schibsted.Infrastructure.Security.Services
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Crosscutting.Entities;
    using Schibsted.Infrastructure.Repositories;
    using Schibsted.Infrastructure.Security.Contracts;

    public class AuthorizationService : IAuthorizeService
    {

        private readonly UsersRepository _usersService;
        private readonly RolesRepository _rolesService;

        public AuthorizationService()
        {
            _usersService = Activator.CreateInstance<UsersRepository>();
            _rolesService = Activator.CreateInstance<RolesRepository>();
        }

        public ISchibstedIdentity Authorize(string username)
        {
            throw new NotImplementedException();
        }

        public bool Authenticate(string username, string password)
        {
            Expression<Func<User, bool>> filter = u => u.Name == username && u.Password == password;

            return _usersService.GetByFilter(filter).AsQueryable().Any();
        }

    }
}
