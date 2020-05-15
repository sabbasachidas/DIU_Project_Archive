using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArcive_DIU.Model.Model
{
    public class Project
    {
        public int Id { set; get; }
        public string Title { set; get; }
        public string Type { set; get; }
        public string SubmittedBy { get; set; }
        public string SupervisedBy { get; set; }
        public int TeamSize { set; get; }
        public string Semester { set; get; }
        public string Level { get; set; }
        public string Description { set; get; }
        public string Technology { get; set; }
        public string Screenshot { set; get; }
        public string Image { get; set; }
        public string Github { set; get; }
        public string Report { set; get; }
        public string Youtube { set; get; }
        public string ContactOfDeveloper { get; set; }
    }
}
