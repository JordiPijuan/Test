using System.Web.Mvc;
using System.Web.Security;
using Schibsted.Business.Contracts;
using Schibsted.Crosscutting.Entities;
using Schibsted.Presentation.Mvc.UI.Filters;

namespace Schibsted.Presentation.Mvc.UI.Controllers
{

    public class HomeController : Controller
    {
        private readonly IRepositoryService _usersService;

        public HomeController(IRepositoryService usersService)
        {
            _usersService = usersService;
        }

        [AuthenticationFilter(true)]
        public ActionResult Page1(string name)
        {
            var user = GetUser(name);

            return View("Page1", user);
        }

        [AuthenticationFilter(true)]
        public ActionResult Page2(string name)
        {
            var user = GetUser(name);

            return View("Page2", user);
        }

        [AuthenticationFilter(true)]
        public ActionResult Page3(string name)
        {
            var user = GetUser(name);

            return View("Page3", user);
        }

        private User GetUser(string name)
        {
            var fileUsers = HttpContext.Server.MapPath("~/Data/UsersModel.js");

            if (_usersService != null && !string.IsNullOrWhiteSpace(_usersService.FilePath))
                _usersService.Initialize(fileUsers);

            return _usersService.GetByName(name);
        }

    }
}