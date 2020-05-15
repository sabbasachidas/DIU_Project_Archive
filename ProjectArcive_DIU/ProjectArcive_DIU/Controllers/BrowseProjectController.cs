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
    public class BrowseProjectController : Controller
    {
        ProjectManager _projectManager = new ProjectManager();

        [HttpGet]
        public ActionResult Show()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            projectViewModel.Projects = _projectManager.GetAll();
            return View(projectViewModel);
        }

        public ActionResult webProject()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "Web").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }

        public ActionResult androidProject()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "Android").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }

        public ActionResult desktopProject()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "Desktop").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }

        public ActionResult embeddedProject()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "Embedded System").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }

        public ActionResult networkingProject()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "Networking").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }

        public ActionResult gameProject()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "Game").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }

        public ActionResult Thesis()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "Thesis").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }

        public ActionResult IOS()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "IOS").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }

        public ActionResult ThesisBsc()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "Thesis").Where(c => c.Level == "B.Sc").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }
        public ActionResult ThesisMsc()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            var webProjects = _projectManager.GetAll();
            webProjects = webProjects.Where(c => c.Type == "Thesis").Where(c => c.Level == "M.Sc").ToList();
            projectViewModel.Projects = webProjects;
            return View(projectViewModel);
        }
    }
}