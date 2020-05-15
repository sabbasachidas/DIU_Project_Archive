using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArcive_DIU.Model.Model;
using ProjectArcive_DIU.Repository.Repository;

namespace ProjectArcive_DIU.Bll.Bll
{
    public class UserManager
    {
        UserRepository _userRepository = new UserRepository();

        public bool Registration(User user)
        {
            return _userRepository.Registration(user);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
