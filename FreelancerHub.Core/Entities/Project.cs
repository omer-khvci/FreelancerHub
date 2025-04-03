using FreelancerHub.Core.Enums;

namespace FreelancerHub.Core.Entities;

public class Project: Base
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string Budget { get; set; }
    public ProjectStatus Status { get; set; }
    public Guid EmployerId { get; set; }
    public User Employer { get; set; }
}