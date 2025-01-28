using ProjectTrackingSystem.Entities;

namespace ProjectTrackingSystem.DataAccess
{
    public class ProjectManagementDbContext
    {
        public List<Project> Projects { get; set; }

        public bool SaveChanges()
        {
            return true;
        }
    }
}
