using System.Web;
using System.Web.Http.Filters;
using System.Web.Mvc;
using Schibsted.Presentation.Mvc.UI.Filters;

namespace Schibsted.Presentation.Mvc.UI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

    }
}
