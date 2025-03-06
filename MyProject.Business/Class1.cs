using MyProject.DataAccess;
using MyProject.DataAccess.DTOs;
using MyProject.Mappings;

namespace MyProject.Business.Services
{
    public class ProjectService
    {
        public List<ProjectDTO> GetAllProjects()
        {
            List<Project> projects = new List<Project>
            {
                new Project { Id = 1, Name = "E-Commerce Website", Description = "Online shopping website" },
                new Project { Id = 2, Name = "Mobile App", Description = "Mobile application project" },
                new Project { Id = 3, Name = "ERP System", Description = "Enterprise Resource Planning" }
            };

            return projects.Select(p => p.ToDTO()).ToList();
        }
    }
}



