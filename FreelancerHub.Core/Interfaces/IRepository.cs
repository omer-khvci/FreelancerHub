using System.Linq.Expressions;

namespace FreelancerHub.Core.Interfaces;

public interface IRepository<T> where T : class
{
    Task<T?> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    Task<IReadOnlyList<T>> ListAsync(Expression<Func<T, bool>> predicate);
    Task AddAsync(T entity);
    void UpdateAsync(T entity);
    void DeleteAsync(Guid id);
}
