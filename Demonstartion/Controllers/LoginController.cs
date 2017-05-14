using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Demonstartion.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(tblSignUpDetail user)
        {
            UserEntities userEntityobj = new UserEntities();

            int? status = userEntityobj.FnValidate(user.Username, user.Password);

            string message = string.Empty;

            if (status == 0)
            {
                message = "Username and/or password is incorrect.";
            }
            else
            {
                FormsAuthentication.SetAuthCookie(user.Username, user.RememberMe);
                //return RedirectToAction("UserPage");
            }
            ViewBag.Message = message;
            return View(user);
        }

        [HttpPost]
        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}