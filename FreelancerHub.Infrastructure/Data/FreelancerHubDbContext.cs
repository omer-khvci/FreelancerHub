using FreelancerHub.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FreelancerHub.Infrastructure.Data;

public class FreelancerHubDbContext : DbContext
{
    public FreelancerHubDbContext(DbContextOptions<FreelancerHubDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> User { get; set; }
    public DbSet<Project> Project { get; set; }
    public DbSet<Proposal> Proposal { get; set; }
    public DbSet<Review> Review { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (!typeof(Base).IsAssignableFrom(entityType.ClrType)) continue;
            modelBuilder.Entity(entityType.ClrType).Property(nameof(Base.CreateDate)).HasDefaultValueSql("NOW()");
            modelBuilder.Entity(entityType.ClrType).Property(nameof(Base.Active)).HasDefaultValue(true);
        }
    }
}