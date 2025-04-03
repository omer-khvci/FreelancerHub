using System.Linq.Expressions;
using FreelancerHub.Core.Entities;
using FreelancerHub.Core.Interfaces;
using FreelancerHub.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace FreelancerHub.Infrastructure.Repositories;

public class EfRepository<T> : IRepository<T> where T : Base
{
    private readonly FreelancerHubDbContext _dbContext;
    private readonly DbSet<T> _dbSet;
    
    public EfRepository(FreelancerHubDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = dbContext.Set<T>();
    }
    public async Task<T?> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<IReadOnlyList<T>> ListAsync(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(T entity)
    {
        entity.CreateDate = DateTime.UtcNow;
        await _dbSet.AddAsync(entity);
        await _dbContext.SaveChangesAsync();
    }

    public void UpdateAsync(T entity)
    {
        entity.UpdatedDate = DateTime.Now;
        _dbSet.Update(entity);
        _dbContext.SaveChanges();
    }

    public void DeleteAsync(Guid id)
    {
        var entity = _dbSet.Find(id) ?? throw new Exception("Entity not found");
        
        entity.Active = false;
        _dbSet.Update(entity);
        _dbContext.SaveChanges();

    }
}