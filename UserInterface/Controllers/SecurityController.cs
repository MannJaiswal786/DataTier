using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace UserInterface.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        // GET: Security
        private DbFirstEntities1 context;
        public SecurityController()
        {
            context = new DbFirstEntities1();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string email, string password)
        {
            //validate --> redirect to home
            if (Membership.ValidateUser(email, password))
            {
                FormsAuthentication.SetAuthCookie(email, false);
                return RedirectToAction("Index", "Categorys");
            }
            else
            {
                TempData["ErrorMsg"] = "Email/Password is incorrect.";
                return RedirectToAction("Login");
            }
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(string username, string email, string password)
        {
            User obj = new User();
          //  obj.UserId = 3;
            obj.Email = email;
            obj.UserName = username;
            obj.Password = password;

            context.Users.Add(obj);
            context.SaveChanges();

            return RedirectToAction("Login");
        }
    }
}