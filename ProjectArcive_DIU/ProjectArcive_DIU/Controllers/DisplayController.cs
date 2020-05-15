using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using ProjectArcive_DIU.Bll.Bll;
using ProjectArcive_DIU.Model.Model;
using ProjectArcive_DIU.Models;
using System.IO;

namespace ProjectArcive_DIU.Controllers
{
    public class DisplayController : Controller
    {
        ProjectManager _projectManager = new ProjectManager();
        [HttpGet]
        public ActionResult Display(int id)
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var projects = _projectManager.GetAll();
            string message = "";
            if (id != null)
            {
                projects = projects.Where(c => c.Id == id).ToList();
                projectViewModel.ShowProject = projects[0];
            }
            else
            {
                message = "Something Happened Wrong!!!";
            }

            ViewBag.Message = message;
            return View(projectViewModel);
        }

    }
}