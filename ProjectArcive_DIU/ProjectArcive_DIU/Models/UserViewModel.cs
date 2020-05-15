using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectArcive_DIU.Models;
using ProjectArcive_DIU.Model.Model;
using System.ComponentModel.DataAnnotations;

namespace ProjectArcive_DIU.Models
{
    public class UserViewModel
    {
        public int Id { set; get; }
        [Required(ErrorMessage = "Can not be Empty!")]
        public string UserName { set; get; }

        [Required(ErrorMessage = "Can not be Empty!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Can not be Empty!")]
        public string Password { set; get; }


        [Required(ErrorMessage = "Can not be Empty!")]
        public string UserType { set; get; }

        [Required(ErrorMessage = "Can not be Empty!")]
        public string Identity { set; get; }


    }
}