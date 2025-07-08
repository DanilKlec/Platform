using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Platform.Application;
using Platform.Domain;
using Platform.Repository;
using System.Reflection;

namespace Platform.Services;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует инфраструктуру ядра (Core) и все сервисы
    /// </summary>
    public static IServiceCollection AddCoreInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        // Подключение к базе
        var connectionString = config.GetConnectionString("Default");
        services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString))); // Или .UseMySql / .UseSqlite и т.д.

        // AutoMapper — сканируем все сборки
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        // Репозиторий
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

        // Query сервис
        services.AddScoped<IDataQueryService, DataQueryService>();

        // Init StaticDb (в Program.cs)
        services.AddSingleton<IServiceProvider>(sp =>
        {
            StaticDb.Init(sp); // Инициализация глобального доступа к БД
            return sp;
        });

        return services;
    }

    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<>), typeof(NullRepository<>)); // по умолчанию — без БД
        services.AddAutoMapper(Assembly.GetExecutingAssembly()); // AutoMapper
        return services;
    }

    public static class StaticDb
    {
        public static IServiceProvider? Provider { get; private set; }

        public static void Init(IServiceProvider provider)
        {
            Provider = provider;
        }

        public static AppDbContext Db => Provider!.GetRequiredService<AppDbContext>();

        public static IQueryable<TEntity> Query<TEntity>() where TEntity : EntityDomain =>
            Db.Set<TEntity>().AsQueryable();
    }
}
