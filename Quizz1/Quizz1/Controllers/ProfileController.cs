using Quizz1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quizz1.Controllers
{
    public class ProfileController : Controller
    {
        public static User loggedInUser = null;

        public ActionResult Index()
        {
            var users = UserList.UsersList;

            if (loggedInUser == null)
            {
                return RedirectToAction("Login");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User Login)
        {
            try
            {
                if (Login != null)
                {
                    var enteredUser = UserList.UsersList.FirstOrDefault(u => u.Email == Login.Email && u.Password == Login.Password);
                    if (enteredUser != null)
                    {
                        if (enteredUser.isFirstLogin == true)
                        {
                            loggedInUser = enteredUser;
                            return RedirectToAction("CreatePassword");
                        }
                        else
                        {
                            loggedInUser = enteredUser;
                            Session["loggedInUser"] = enteredUser;

                            return RedirectToAction("Index", "Home");
                        }
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Invalid email or password.";
                        return View();
                    }
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult CreatePassword()
        {
            ViewBag.rame = loggedInUser.Name;
            return View();
        }


        [HttpPost]
        public ActionResult CreatePassword(User User)
        {
            if (User.Password != null && User.Password_check != null && User.Password == User.Password_check)
            {
                int index = UserList.UsersList.FindIndex(x => x.Id == loggedInUser.Id);

                if (index > 0)
                {
                    UserList.UsersList[index].Password = User.Password;
                    UserList.UsersList[index].isFirstLogin = false;
                    Logout();
                    return RedirectToAction("Login");

                }
            }
            return RedirectToAction("Login");
        }

        public ActionResult ResetPassword()
        {
            return View();
        }

        [HttpPut]
        public ActionResult ResetPassword(User user)
        {
            int index = UserList.UsersList.FindIndex(x => x.Email == user.Email);
            if (index > 0)
            {
                UserList.UsersList[index].Password = "12345678";
                UserList.UsersList[index].isFirstLogin = true;
                return RedirectToAction("Index", "Home");

            }
            return View();
        }

        public void Logout()
        {
            loggedInUser = null;
            Session["loggedInUser"] = null;
        }
    }
}