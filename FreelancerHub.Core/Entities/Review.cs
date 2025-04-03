namespace FreelancerHub.Core.Entities;

public class Review: Base
{
    public Guid ProjectId { get; set; }
    public Project Project { get; set; }
    public Guid ReviewerId { get; set; }
    public User Reviewer { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
}