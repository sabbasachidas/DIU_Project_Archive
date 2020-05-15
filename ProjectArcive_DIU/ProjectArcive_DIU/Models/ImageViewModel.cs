using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectArcive_DIU.Models;
using ProjectArcive_DIU.Model.Model;
using System.ComponentModel.DataAnnotations;

namespace ProjectArcive_DIU.Models
{
    public class ImageViewModel
    {
        public int Id { set; get; }
        public string FileName { get; set; }
        public string filePath { get; set; }
    }
}