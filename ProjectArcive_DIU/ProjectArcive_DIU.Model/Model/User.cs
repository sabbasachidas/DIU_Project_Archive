using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectArcive_DIU.Model.Model
{
    public class User
    {
        public int Id { set; get; }
        public string UserName { set; get; }
        public string Email { get; set; }
        public string Password { set; get; }
        public string UserType { set; get; }
        public string Identity { set; get; }
    }
}
