using Platform.Domain;

namespace Platform.Services;

public interface IDataQueryService
{
    IQueryable<T> Query<T>() where T : Entity;
}
