using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Demonstartion.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult UserPage()
        {
            return View();
        }
   
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Index(tblSignUpDetail user)
        {
            // UserEntities is a class that inherits DBContext Class
            // and same is the connection data name req to connect to db

            UserEntities userEntityobj = new UserEntities();

            // Creating a obj and adding users to class(entity i.e to DB)

            userEntityobj.tblSignUpDetails.Add(user);

            userEntityobj.SaveChanges();

            string alert = string.Empty;

            int userId = user.UserID;
 
            // Choosing the case depending on return type of usp.

            switch (userId)
            {
                case -1:
                    alert = "Username already exists.\\nPlease choose a different username";
                    break;
                case -2:
                    alert = "Supplied email address has already been used";
                    break;
                default:
                    alert = "Registration successful";
                    break;
            }

            ViewBag.Message = alert;
            return View("UserPage");
        }

    }
}