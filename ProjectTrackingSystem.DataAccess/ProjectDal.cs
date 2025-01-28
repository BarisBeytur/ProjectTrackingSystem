using ProjectTrackingSystem.Core.Request.Project;
using ProjectTrackingSystem.Core.Response.Project;
using ProjectTrackingSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrackingSystem.DataAccess
{
    // Generic repository dp kullanılabilir.
    public class ProjectDal
    {

        public ProjectResponse Insert(ProjectRequest request)
        {
            // automapper kullanılabilir.
            ProjectManagementDbContext dbContext = new ProjectManagementDbContext();
            Project project = new Project();
            project.Name = request.Name;
            project.Description = request.Description;

            dbContext.Projects.Add(project);

            if(dbContext.SaveChanges())
            {
                return new ProjectResponse
                {
                    IsSuccess = true,
                    Message = "Project created successfully",
                    Id = project.Id
                };
            }

            return new ProjectResponse
            {
                IsSuccess = false,
                Message = "An error occured while creating project"
            };

        }

    }
}
