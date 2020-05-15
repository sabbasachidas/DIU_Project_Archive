using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArcive_DIU.Model.Model;
using ProjectArcive_DIU.Repository.Repository;

namespace ProjectArcive_DIU.Bll.Bll
{
    public class BrowseProjectManager
    {
        ProjectRepository _projectRepository = new ProjectRepository();

        public List<Project> GetAll()
        {
            return _projectRepository.GetAll();
        }

        public Project GetById(int id)
        {
            return _projectRepository.GetById(id);
        }
    }
}
