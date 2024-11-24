    using MidTerm.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using System.Web.UI.WebControls;

    namespace MidTerm.Controllers
    {
        public class LoginController : Controller
        {

            public static User loggedInUser = null;

            // GET: Login
            public ActionResult Index()
            {
                var users = UserList.UsersList;

                if (loggedInUser != null)
                {
                    return RedirectToAction("UserDetails");
                }
                else
                {
                    return RedirectToAction("Login");
                }
            }

            public ActionResult Login()
            {
                return View();
            }


        [HttpPost]
        public ActionResult Login(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                var user = UserList.UsersList.FirstOrDefault(u =>
                    u.UserLogin.UserName == login.UserName &&
                    u.UserLogin.Password == login.Password);

                if (user != null)
                {
                    loggedInUser = user;
                    return RedirectToAction("UserDetails");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password.");
                    return View("Login", login); 
                }
            }
            else
            {
                return View("Login", login);  
            }
        }

        public ActionResult UserDetails()
            {
                if (loggedInUser == null)
                {
                return RedirectToAction("Login");
                }
                ViewBag.LoggedInUser = loggedInUser;
                
                return View(loggedInUser);
            }

        public ActionResult Logout()
        {
            loggedInUser = null;
            return RedirectToAction("Login");
        }

    }
    }