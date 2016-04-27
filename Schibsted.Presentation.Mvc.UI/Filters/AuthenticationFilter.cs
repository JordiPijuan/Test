using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Http.Controllers;
using Schibsted.Business.Contracts;

namespace Schibsted.Presentation.Mvc.UI.Filters
{

    public class AuthenticationFilter : GenericAuthenticationFilter
    {
        /// <summary>
        /// Default Authentication Constructor
        /// </summary>
        public AuthenticationFilter()
        {
        }

        /// <summary>
        /// AuthenticationFilter constructor with isActive parameter
        /// </summary>
        /// <param name="isActive"></param>
        public AuthenticationFilter(bool isActive)
            : base(isActive)
        {
        }

        public string Roles { get; set; }

        /// <summary>
        /// Protected overriden method for authorizing user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="actionContext"></param>
        /// <returns></returns>
        protected override bool OnAuthorizeUser(string username, string password, HttpActionContext actionContext)
        {
            var provider = actionContext.ControllerContext.Configuration
                               .DependencyResolver.GetService(typeof(IRepositoryService)) as IRepositoryService;
            if (provider != null)
            {
                var userId = provider.GetByName(username);
                if (userId != null)
                {
                    var basicAuthenticationIdentity = Thread.CurrentPrincipal.Identity as SchibstedIdentity;
                    if (basicAuthenticationIdentity != null)
                        basicAuthenticationIdentity.UserName = userId.Name;
                    return true;
                }
            }
            return false;
        }
    }
}
