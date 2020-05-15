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

namespace ProjectArcive_DIU.Controllers
{
    public class RegisterController : Controller
    {
       UserManager _userManager = new UserManager();
       [HttpGet]
        public ActionResult Register()
        {
            UserViewModel userViewModel = new UserViewModel();
            return View();
        }

        [HttpPost]
        public ActionResult Register(UserViewModel userViewModel)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                User user = Mapper.Map<User>(userViewModel);
                if (_userManager.Registration(user))
                {
                    message = "Registered successfully!";
                }
                else
                {
                    message = "Not Registered";
                }
            }
            else
            {
                message = "ModalState Failed!";
            }

            ViewBag.Message = message;
            return View(userViewModel);
        }



        
    }
}