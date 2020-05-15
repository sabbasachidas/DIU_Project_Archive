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
using System.Web.Mvc.Html;

namespace ProjectArcive_DIU.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        ProjectManager _projectManager = new ProjectManager();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult underConstruction()
        {
            return View();
        }

        public ActionResult MyProjects()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var myProjects = _projectManager.GetAll();
            string id = Convert.ToString(Session["UserId"]);
            
            myProjects = myProjects.Where(c => c.SubmittedBy == id).ToList();
            projectViewModel.Projects = myProjects;
            return View(projectViewModel);
        }
    }
}