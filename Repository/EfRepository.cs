using Microsoft.EntityFrameworkCore;
using Platform.Application;
using Platform.Domain;
using System.Linq.Expressions;

namespace Platform.Repository;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    private readonly AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<TEntity> Query() => _context.Set<TEntity>().AsQueryable();

    public Task<TEntity?> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate) =>
        Query().FirstOrDefaultAsync(predicate);

    public Task<List<TEntity>> ToListAsync(Expression<Func<TEntity, bool>>? predicate = null) =>
        predicate == null ? Query().ToListAsync() : Query().Where(predicate).ToListAsync();

    public async Task AddAsync(TEntity entity)
    {
        _context.Add(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _context.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        if (entity == null) return;
        entity.IsDeleted = true;
        await _context.SaveChangesAsync();
    }

    public async Task DeleteByIdAsync(int id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        if (entity == null) return;
        entity.IsDeleted = true;
        await _context.SaveChangesAsync();
    }

    public async Task<TEntity?> GetEntityAsync(int id)
    {
        return await _context.Set<TEntity>().FirstOrDefaultAsync(_ => _.Id == id);
    }
}
