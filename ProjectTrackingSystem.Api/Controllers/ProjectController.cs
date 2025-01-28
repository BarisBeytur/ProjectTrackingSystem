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

        [HttpPost(Name = "CreateProject")]
        public IActionResult Create([FromBody]ProjectRequest request)
        {
            ProjectService projectService = new ProjectService();
            var response = projectService.CreateProject(request);

            if (!response.IsSuccess)
            {
                return BadRequest(response);
            }

            return Ok(response);
        }
    }
}
