namespace Schibsted.Infrastructure.Security.Providers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Security;

    public class SchibstedRoleProvider : RoleProvider, IDisposable
    {
        private readonly SchibstedMembershipProvider _provider;
        public override string ApplicationName { get; set; }
        internal IList<string> Roles { get; set; }

        public SchibstedRoleProvider()
        {
            _provider = Activator.CreateInstance<SchibstedMembershipProvider>();
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            SetRoles(username);

            return Roles.Contains(roleName);
        }

        public override string[] GetRolesForUser(string username)
        {
            SetRoles(username);

            return Roles.ToArray();
        }

        private void SetRoles(string username)
        {
            if (Roles == null)
            {
                Roles = _provider
                    .Authorize(username)
                    .Roles
                    .ToArray();
            }
        }

        #region · Not Implemented

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion Not Implemented

    }

}
