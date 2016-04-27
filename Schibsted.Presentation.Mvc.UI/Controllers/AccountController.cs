using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Schibsted.Business.Contracts;
using Schibsted.Crosscutting.Commons.Enums;
using Schibsted.Crosscutting.Entities;
using Schibsted.Presentation.Mvc.UI.Enums;
using Schibsted.Presentation.Mvc.UI.Localization;

namespace Schibsted.Presentation.Mvc.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepositoryService _usersService;
        public List<User> UserList { get; set; }

        public AccountController(IRepositoryService usersService)
        {
            _usersService = usersService;
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string name, string password)
        {
            var fileUsers = HttpContext.Server.MapPath(RouteFiles.UsersRoute);
            _usersService.Initialize(fileUsers);

            var user = _usersService.GetByName(name);
            var actionName = GetAction(user.Roles);

            return RedirectToAction(
                actionName,
                "Home",
                new { name = user.Name }
            );
        }

        public ActionResult Logout()
        {
            return View("Index");
        }

        private string GetAction(string role)
        {
            var targetRole = (SchibstedRole)Enum.Parse(typeof(SchibstedRole), role);
            var actionName = string.Empty;

            switch (targetRole)
            {
                case SchibstedRole.PAGE_1:
                    actionName = UserAction.Page1.ToString();
                    break;
                case SchibstedRole.PAGE_2:
                    actionName = UserAction.Page2.ToString();
                    break;
                case SchibstedRole.PAGE_3:
                    actionName = UserAction.Page3.ToString();
                    break;
            }

            return actionName;
        }

    }

}