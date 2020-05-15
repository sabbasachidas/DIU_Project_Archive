using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using AutoMapper;
using ProjectArcive_DIU.Bll.Bll;
using ProjectArcive_DIU.Model.Model;
using ProjectArcive_DIU.Models;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace ProjectArcive_DIU.Controllers
{
    public class ProjectController : Controller
    {
        ProjectManager _projectManager = new ProjectManager();

        [HttpGet]
        public ActionResult Add()
        {
            ProjectViewModel projectViewModel = new ProjectViewModel();
            projectViewModel.Projects = _projectManager.GetAll();
            return View(projectViewModel);
        }

        [HttpPost]
        public ActionResult Add(ProjectViewModel projectViewModel, HttpPostedFileBase Image)
        {
            string message = "";
            string imageStatus = "";
            if (ModelState.IsValid)
            {
                if (Image != null && Image.ContentLength > 0)
                {
                    string screenshot = System.IO.Path.GetFileName(Image.FileName);
                    string physicalPath = Server.MapPath("~/Images/" + screenshot);
                    Image.SaveAs(physicalPath);
                    
                    projectViewModel.Image = "~/Images/" + screenshot;
                }
                else
                {
                    imageStatus = "Not Saved!";
                }
                Project project = Mapper.Map<Project>(projectViewModel);
                if (_projectManager.Add(project))
                {
                    message = "Saved";
                }
                else
                {
                    message = "Not Saved";
                }
            }
            else
            {
                message = "ModalState Failed!";
            }

            ViewBag.Message = message;
            ViewBag.imageStatus = imageStatus;
            projectViewModel.Projects = _projectManager.GetAll();
            return View(projectViewModel);
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var project = _projectManager.GetById(id);
            ProjectViewModel projectViewModel = Mapper.Map<ProjectViewModel>(project);
            return View(projectViewModel);
        }
        [HttpPost]
        public ActionResult Update(ProjectViewModel projectViewModel)
        {
            string message = "";
            if (ModelState.IsValid)
            {
                Project project = Mapper.Map<Project>(projectViewModel);
                if (_projectManager.Update(project))
                {
                    message = "Updated successfully!!";
                }
                else
                {
                    message = "Not updated!!!";
                }
            }
            else
            {
                message = "Modelstate failed!!!";
            }

            ViewBag.Message = message;
            return View(projectViewModel);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var project = _projectManager.GetById(id);
            ProjectViewModel projectViewModel = Mapper.Map<ProjectViewModel>(project);
            return View(projectViewModel);
        }

        [HttpPost]
        public ActionResult Delete(ProjectViewModel projectViewModel)
        {
            string message = "";
            Project project = Mapper.Map<Project>(projectViewModel);
            if (_projectManager.Delete(project.Id))
            {
                message = "Deleted successfully!";
            }
            else
            {
                message = "Not deleted!!!";
            }
            

            ViewBag.Message = message;
            return View(projectViewModel);
        }
    }
}