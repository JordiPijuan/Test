using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Filters;
using Schibsted.Presentation.Mvc.UI.Filters;

namespace Schibsted.Presentation.Mvc.UI.App_Start
{

    public static class WebApiConfig
    {

        public static void Register(HttpConfiguration config)
        {
            // TODO: Add any additional configuration code.

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "WebAPI/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void RegisterHttpFilters(HttpFilterCollection filters)
        {
            filters.Add(new AuthenticationFilter());
        }

    }

}