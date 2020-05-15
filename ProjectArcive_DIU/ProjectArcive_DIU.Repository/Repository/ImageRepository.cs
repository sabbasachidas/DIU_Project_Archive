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
    public class ImageRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Upload(Image image)
        {
            _dbContext.Images.Add(image);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
