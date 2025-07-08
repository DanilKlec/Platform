using System.Linq.Expressions;

namespace Platform.Services;

public static class LinqExtensions
{
    /// <summary>
    /// Динамическая сортировка по названию свойства
    /// </summary>
    /// <typeparam name="T">Тип сущности</typeparam>
    /// <param name="source">Источник IQueryable</param>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="descending">true — OrderByDescending, false — OrderBy</param>
    /// <returns>IQueryable с применённой сортировкой</returns>
    public static IQueryable<T> OrderByDynamic<T>(this IQueryable<T> source, string propertyName, bool descending = false)
    {
        if (string.IsNullOrWhiteSpace(propertyName))
            return source;

        var parameter = Expression.Parameter(typeof(T), "x");
        var property = Expression.PropertyOrField(parameter, propertyName);
        var lambda = Expression.Lambda(property, parameter);

        var methodName = descending ? "OrderByDescending" : "OrderBy";

        var methodCall = Expression.Call(
            typeof(Queryable),
            methodName,
            new Type[] { typeof(T), property.Type },
            source.Expression,
            Expression.Quote(lambda)
        );

        return source.Provider.CreateQuery<T>(methodCall);
    }
}
