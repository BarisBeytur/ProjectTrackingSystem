using Microsoft.AspNetCore.Mvc;
using ProjectTrackingSystem.Business;
using ProjectTrackingSystem.Core.Request.Project;
using ProjectTrackingSystem.Core.Response.Project;

namespace ProjectTrackingSystem.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectController : ControllerBase
    {

        private readonly ILogger<ProjectController> _logger;

        public ProjectController(ILogger<ProjectController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "CreateProject")]
        public ProjectResponse Create(ProjectRequest request)
        {
            ProjectService projectService = new ProjectService();
            return projectService.CreateProject(request);

        }
    }
}
