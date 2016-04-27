using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Schibsted.Presentation.Mvc.UI.Attributes
{

    public class SchibstedAuthorize : AuthorizeAttribute
    {

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            if (filterContext.HttpContext.User.Identity.IsAuthenticated &&
                filterContext.Result is HttpUnauthorizedResult)
            {
                throw new UnauthorizedAccessException();
            }
        }

    }

}