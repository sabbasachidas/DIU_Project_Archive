using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectArcive_DIU.Model.Model;
using ProjectArcive_DIU.Repository.Repository;

namespace ProjectArcive_DIU.Bll.Bll
{
    public class ProjectManager
    {
        ProjectRepository _projectRepository = new ProjectRepository();

        public bool Add(Project project)
        {
            return _projectRepository.Add(project);
        }

        public List<Project> GetAll()
        {
            return _projectRepository.GetAll();
        }

        public Project GetById(int id)
        {
            return _projectRepository.GetById(id);
        }

        public bool Update(Project project)
        {
            return _projectRepository.Update(project);
        }

        public bool Delete(int id)
        {
            return _projectRepository.Delete(id);
        }
    }
}
