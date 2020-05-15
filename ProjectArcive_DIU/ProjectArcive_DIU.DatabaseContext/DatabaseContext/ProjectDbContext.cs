using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArcive_DIU.Model.Model;

namespace ProjectArcive_DIU.DatabaseContext.DatabaseContext
{
    public class ProjectDbContext: DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Project> Projects { set; get; }
        public DbSet<Image> Images { set; get; }
    }
}
