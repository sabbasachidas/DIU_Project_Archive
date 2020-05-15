using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectArcive_DIU.Bll.Bll;
using ProjectArcive_DIU.Models;
using ProjectArcive_DIU.Model.Model;
using AutoMapper;
using System.Web.Helpers;
using System.IO;
using System.Web.SessionState;

namespace ProjectArcive_DIU.Controllers
{
    public class LoginController : Controller
    {
        //[SessionState(SessionStateBehavior.Default)]
        LoginManager _loginManager = new LoginManager();
        
        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel loginViewModel)
        {
            var users = _loginManager.GetAll();
            string message = "";
            
            if (loginViewModel.Email != null && loginViewModel.Password != null)
            {
                users = users.Where(c => c.Email.Contains(loginViewModel.Email))
                    .Where(c => c.Password.Contains(loginViewModel.Password)).ToList();
                Model.Model.User loggedInUser = users[0];
                if (users.Count == 1)
                {
                    message = "Logged In!";
                    Session["LoggedIn"] = "Yes";
                    Session["UserName"] = loggedInUser.UserName;
                    Session["UserId"] = loggedInUser.Identity;

                }
                else
                {
                    message = "User Not Found";
                }
            }
            else
            {
                message = "Enter Email & Password!";
            }

            ViewBag.Message = message;
            
            return View(loginViewModel);
        }

        public ActionResult Logout()
        {
            Session.Remove("LoggedIn");
            Session.Remove("UserName");
            Session.Remove("UserId");
            return View();
        }
    }
}