using ProjectTrackingSystem.Core.Request.Project;
using ProjectTrackingSystem.Core.Response.Project;
using ProjectTrackingSystem.DataAccess;

namespace ProjectTrackingSystem.Business
{
    public class ProjectService
    {

        public ProjectResponse CreateProject(ProjectRequest request)
        {

            //UnitOfWork kullanılabilir.
            ProjectDal projectDal = new ProjectDal();
            var response = projectDal.Insert(request);

            if (!response.IsSuccess)
            {
                return new ProjectResponse
                {
                    IsSuccess = false,
                    Message = "Project creation failed"
                };
            }

            return new ProjectResponse
            {
                IsSuccess = true,
                Message = "Project created successfully",
                Id = response.Id
            };

        }

    }
}
