using Platform.Domain;
using System.Linq.Expressions;

namespace Platform.Repository;

public class NullRepository<TEntity> : IRepository<TEntity> where TEntity : EntityDomain
{
    public IQueryable<TEntity> Query() => Enumerable.Empty<TEntity>().AsQueryable();
    public Task<TEntity?> GetEntityAsync(int id) => Task.FromResult<TEntity?>(null);
    public Task<List<TEntity>> ToListAsync(Expression<Func<TEntity, bool>>? predicate = null) =>
        Task.FromResult(new List<TEntity>());
    public Task AddAsync(TEntity entity) => Task.CompletedTask;
    public Task UpdateAsync(TEntity entity) => Task.CompletedTask;
    public Task DeleteAsync(TEntity entity) => Task.CompletedTask;
    public Task DeleteByIdAsync(int id) => Task.CompletedTask;
    public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate) => Task.FromResult<TEntity?>(null);
}
