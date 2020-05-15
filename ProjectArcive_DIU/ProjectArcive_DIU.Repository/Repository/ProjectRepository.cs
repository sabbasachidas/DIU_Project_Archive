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
    public class ProjectRepository
    {
        ProjectDbContext _dbContext = new ProjectDbContext();

        public bool Add(Project project)
        {
            _dbContext.Projects.Add(project);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Project> GetAll()
        {
            return _dbContext.Projects.ToList();
        }

        public Project GetById(int id)
        {
            return _dbContext.Projects.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(Project project)
        {
            Project aProject = _dbContext.Projects.FirstOrDefault(c => c.Id == project.Id);
            if (aProject != null)
            {
                aProject.Title = project.Title;
                aProject.Type = project.Type;
                aProject.SubmittedBy = project.SubmittedBy;
                aProject.SupervisedBy = project.SupervisedBy;
                aProject.TeamSize = project.TeamSize;
                aProject.Semester = project.Semester;
                aProject.Level = project.Level;
                aProject.Description = project.Description;
                aProject.Screenshot = project.Screenshot;
                aProject.Image = project.Image;
                aProject.Github = project.Github;
                aProject.Report = project.Report;
                aProject.Youtube = project.Youtube;
                aProject.ContactOfDeveloper = project.ContactOfDeveloper;
            }

            return _dbContext.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            Project aProject = _dbContext.Projects.FirstOrDefault(c => c.Id == id);
            _dbContext.Projects.Remove(aProject);
            return _dbContext.SaveChanges() > 0;
        }
    }
}
