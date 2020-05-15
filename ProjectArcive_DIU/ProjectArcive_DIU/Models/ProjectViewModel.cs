using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using ProjectArcive_DIU.Models;
using ProjectArcive_DIU.Model.Model;
using System.ComponentModel.DataAnnotations;

namespace ProjectArcive_DIU.Models
{
    public class ProjectViewModel
    {
        public int Id { set; get; }
        [Required(ErrorMessage = "Can not be Empty!")]
        [DisplayName("Project Title")]
        public string Title { set; get; }

        [DisplayName("Type/Platform")]
        [Required(ErrorMessage = "Can not be Empty!")]
        public string Type { set; get; }

        [Required(ErrorMessage = "Can not be Empty!")]
        [DisplayName("Submitted By")]
        public string SubmittedBy { get; set; }

        [DisplayName("Supervisor Name")]
        public string SupervisedBy { get; set; }

        [DisplayName("Team size(person)")]
        [Required(ErrorMessage = "Can not be Empty!")]
        public int TeamSize { set; get; }

        [DisplayName("Defense semester")]
        [Required(ErrorMessage = "Can not be Empty!")]
        public string Semester { set; get; }

        [Required(ErrorMessage = "Can not be Empty!")]
        public string Level { get; set; }


        [Required(ErrorMessage = "Can not be Empty!")]
        public string Description { set; get; }

        [Required(ErrorMessage = "Can not be Empty!")]
        [DisplayName("Technology used(separate by comma',')")]
        public string Technology { set; get; }

        [DisplayName("Screenshot link")]
        public string Screenshot { set; get; }
        public string Image { set; get; }

        [DisplayName("Github Link")]
        public string Github { set; get; }

        [DisplayName("Report Link(google drive)")]
        public string Report { set; get; }

        [DisplayName("Youtube Link")]
        public string Youtube { set; get; }

        [Required(ErrorMessage = "Can not be Empty!")]
        [DisplayName("Developer's mobile number")]
        public string ContactOfDeveloper { get; set; }

        public List<Project> Projects { set; get; }

        public Project ShowProject { get; set; }
    }
}