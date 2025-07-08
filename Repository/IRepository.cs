using Platform.Domain;
using System.Linq.Expressions;

namespace Platform.Repository;

public interface IRepository<TEntity>
{
    IQueryable<TEntity> Query();
    Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    Task<List<TEntity>> ToListAsync(Expression<Func<TEntity, bool>>? predicate = null);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(TEntity entity);
    Task DeleteByIdAsync(int id);
    Task<TEntity?> GetEntityAsync(int id);
}
