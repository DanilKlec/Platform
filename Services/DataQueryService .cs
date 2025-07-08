using Platform.Application;
using Platform.Domain;

namespace Platform.Services;

public class DataQueryService : IDataQueryService
{
    private readonly AppDbContext _context;

    public DataQueryService(AppDbContext context)
    {
        _context = context;
    }

    public IQueryable<T> Query<T>() where T : EntityDomain
    {
        return _context.Set<T>().AsQueryable();
    }
}
