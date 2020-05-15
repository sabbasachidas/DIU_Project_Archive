using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArcive_DIU.Model.Model;
using ProjectArcive_DIU.DatabaseContext;
using ProjectArcive_DIU.DatabaseContext.DatabaseContext;

namespace ProjectArcive_DIU.Repository.Repository
{
    public class UserRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Registration(User user)
        {
            _dbContext.Users.Add(user);
            return _dbContext.SaveChanges() > 0;
        }

        public List<User> GetAll()
        {
            return _dbContext.Users.ToList();
        }

    }
}
