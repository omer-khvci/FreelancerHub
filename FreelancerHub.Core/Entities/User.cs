using System.ComponentModel.DataAnnotations.Schema;

namespace FreelancerHub.Core.Entities;

public class User: Base
{
    public string Name { get; set; }
    public string Surname { get; set; }
    [NotMapped] public string FullName => Name + " " + Surname;
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
}