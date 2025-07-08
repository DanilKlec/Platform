# Универсальное ядро (Core) для C# проектов

Цель

Создать переиспользуемое ядро (Core), которое можно подключать к любому C# проекту (ASP.NET Core MVC, Web API, Console), где при добавлении новой сущности нужно лишь:

Добавить Domain-сущность (например, Product)

Опционально: добавить DTO (например, ProductDto)

Создать контроллер (наследник BaseController<,>, например, ProductsController)

И всё — не нужно регистрировать DbSet, AutoMapper-профили, репозитории и сервисы вручную.

Структура проекта

1. Domain

public abstract class Entity : EntityBase<int> { }

public abstract class EntityBase<TKey>
{
    public TKey Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
}

2. DTO

public abstract class DtoBase
{
    public int Id { get; set; }
}

DTO должны называться по шаблону: ProductDto, UserDto и т.д.

3. DbContext (AppDbContext)

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var entityTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => !t.IsAbstract && typeof(Entity).IsAssignableFrom(t));

        foreach (var type in entityTypes)
        {
            modelBuilder.Entity(type);
            modelBuilder.Entity(type).HasQueryFilter(
                EF.Property<bool>(Activator.CreateInstance(type)!, "IsDeleted") == false);
        }

        base.OnModelCreating(modelBuilder);
    }
}

4. AutoMapper автоматический профиль

public class AutoMapperProfileGenerator : Profile
{
    public AutoMapperProfileGenerator()
    {
        var assembly = Assembly.GetExecutingAssembly();
        var dtoTypes = assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && typeof(DtoBase).IsAssignableFrom(t))
            .ToList();

        foreach (var dtoType in dtoTypes)
        {
            var entityName = dtoType.Name.Replace("Dto", "");
            var entityType = assembly.GetTypes()
                .FirstOrDefault(t => t.Name == entityName && typeof(Entity).IsAssignableFrom(t));

            if (entityType != null)
            {
                CreateMap(entityType, dtoType).ReverseMap();
            }
        }
    }
}

5. Generic Repository и Service

public interface IRepository<TEntity> where TEntity : Entity
{
    Task<TEntity?> GetByIdAsync(int id);
    Task<IEnumerable<TEntity>> GetAllAsync(bool includeDeleted = false);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(int id);
}

public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : Entity
{
    protected readonly AppDbContext _context;
    protected readonly DbSet<TEntity> _dbSet;

    public EfRepository(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<TEntity>();
    }

    public async Task AddAsync(TEntity entity) { await _dbSet.AddAsync(entity); await _context.SaveChangesAsync(); }
    public async Task UpdateAsync(TEntity entity) { entity.UpdatedAt = DateTime.UtcNow; _dbSet.Update(entity); await _context.SaveChangesAsync(); }
    public async Task DeleteAsync(int id)
    {
        var entity = await _dbSet.FindAsync(id);
        if (entity != null) { entity.IsDeleted = true; _dbSet.Update(entity); await _context.SaveChangesAsync(); }
    }
    public async Task<IEnumerable<TEntity>> GetAllAsync(bool includeDeleted = false) =>
        await _dbSet.Where(e => includeDeleted || !e.IsDeleted).ToListAsync();
    public async Task<TEntity?> GetByIdAsync(int id) => await _dbSet.FindAsync(id);
}

public interface IService<TEntity> where TEntity : Entity
{
    Task<TEntity?> GetByIdAsync(int id);
    Task<IEnumerable<TEntity>> GetAllAsync(bool includeDeleted = false);
    Task AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(int id);
}

public class BaseService<TEntity> : IService<TEntity> where TEntity : Entity
{
    protected readonly IRepository<TEntity> _repo;
    public BaseService(IRepository<TEntity> repo) { _repo = repo; }
    public Task AddAsync(TEntity entity) => _repo.AddAsync(entity);
    public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
    public Task<IEnumerable<TEntity>> GetAllAsync(bool includeDeleted = false) => _repo.GetAllAsync(includeDeleted);
    public Task<TEntity?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);
    public Task UpdateAsync(TEntity entity) => _repo.UpdateAsync(entity);
}

6. Base Controller

[ApiController]
[Route("api/[controller]")]
public class BaseController<TEntity, TDto> : ControllerBase
    where TEntity : Entity
    where TDto : DtoBase
{
    protected readonly IService<TEntity> _service;
    protected readonly IMapper _mapper;

    public BaseController(IService<TEntity> service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    [HttpGet] public async Task<IEnumerable<TDto>> Get() =>
        (await _service.GetAllAsync()).Select(_mapper.Map<TDto>);

    [HttpGet("{id}")] public async Task<ActionResult<TDto>> Get(int id)
    {
        var entity = await _service.GetByIdAsync(id);
        if (entity == null) return NotFound();
        return _mapper.Map<TDto>(entity);
    }

    [HttpPost] public async Task<IActionResult> Post([FromBody] TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        await _service.AddAsync(entity);
        return CreatedAtAction(nameof(Get), new { id = entity.Id }, dto);
    }

    [HttpPut("{id}")] public async Task<IActionResult> Put(int id, [FromBody] TDto dto)
    {
        if (dto.Id != id) return BadRequest();
        var entity = _mapper.Map<TEntity>(dto);
        await _service.UpdateAsync(entity);
        return NoContent();
    }

    [HttpDelete("{id}")] public async Task<IActionResult> Delete(int id)
    {
        await _service.DeleteAsync(id);
        return NoContent();
    }
}

7. DI Extension

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration config)
    {
        var connectionString = config.GetConnectionString("Default");

        services.AddDbContext<AppDbContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
        services.AddScoped(typeof(IService<>), typeof(BaseService<>));

        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        return services;
    }
}

💡 Как использовать

Добавить сущность Product

Добавить ProductDto (если нужно)

Создать ProductsController : BaseController<Product, ProductDto>

Всё ✨ — маппинг, CRUD, фильтрация по IsDeleted, регистрация в DI, миграции — работают автоматически
