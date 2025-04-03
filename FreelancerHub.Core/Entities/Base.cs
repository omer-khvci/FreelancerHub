namespace FreelancerHub.Core.Entities;

public class Base
{
    public Guid Id { get; set; }
    public bool Active { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}