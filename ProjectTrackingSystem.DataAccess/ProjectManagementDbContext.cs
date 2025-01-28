using ProjectTrackingSystem.Entities;

namespace ProjectTrackingSystem.DataAccess
{
    public class ProjectManagementDbContext
    {
        public List<Project> Projects { get; set; } = new List<Project>();

        public bool SaveChanges()
        {
            return true;
        }
    }
}
