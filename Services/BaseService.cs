using Platform.Domain;
using Platform.Repository;

namespace Platform.Services;

public class BaseService<TEntity> : IService<TEntity> where TEntity : EntityDomain
{
    protected readonly IRepository<TEntity> _repository;

    public BaseService(IRepository<TEntity> repository)
    {
        _repository = repository;
    }

    public Task<TEntity?> GetEntityAsync(int id) => _repository.GetEntityAsync(id);

    public Task<IEnumerable<TEntity>> GetEntitiesAsync(bool includeDeleted = false) =>
        Task.FromResult<IEnumerable<TEntity>>(_repository.Query().Where(e => includeDeleted || !e.IsDeleted).AsEnumerable());

    public Task AddAsync(TEntity entity) => _repository.AddAsync(entity);

    public Task DeleteAsync(int id) => _repository.DeleteByIdAsync(id);

    public Task UpdateAsync(TEntity entity) => _repository.UpdateAsync(entity);
}