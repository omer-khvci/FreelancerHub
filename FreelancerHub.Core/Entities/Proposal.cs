using FreelancerHub.Core.Enums;

namespace FreelancerHub.Core.Entities;

public class Proposal: Base
{
    public Guid ProjectId { get; set; }
    public Project Project { get; set; }
    public Guid FreelancerId { get; set; }
    public User Freelancer { get; set; }
    public string CoverLetter { get; set; }
    public decimal ProposedBudget { get; set; }
    public ProposalStatus Status { get; set; }
}