using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectArcive_DIU.Models;
using ProjectArcive_DIU.Model.Model;
using System.ComponentModel.DataAnnotations;

namespace ProjectArcive_DIU.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Can not be Empty!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Can not be Empty!")]
        public string Password { set; get; }
    }
}