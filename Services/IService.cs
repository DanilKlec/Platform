using Platform.Domain;

namespace Platform.Services;

public interface IService<TEntity> where TEntity : Entity
{
    Task<TEntity?> GetEntityAsync(int id);
    Task<IEnumerable<TEntity>> GetEntitiesAsync(bool includeDeleted = false);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(int id);
}
