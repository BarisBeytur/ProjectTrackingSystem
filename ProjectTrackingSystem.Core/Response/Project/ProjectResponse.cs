using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTrackingSystem.Core.Response.Project
{
    public class ProjectResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int Id { get; set; }
    }
}
