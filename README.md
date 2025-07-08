# Универсальное ядро (Core) для C# проектов
# Цель
Создать переиспользуемое ядро (Core), которое можно подключать к любому C# проекту (ASP.NET Core MVC, Web API, Console), где при добавлении новой сущности нужно лишь:

Добавить Domain-сущность (например, Product)

Опционально: добавить DTO, ListDto, FilterDto

Создать контроллер (наследник BaseController<,> например, ProductsController)

И всё — не нужно регистрировать DbSet, AutoMapper-профили, репозитории и сервисы вручную.

# Структура проекта
1. Domain

2. DTO должны называться по шаблону: ProductDto, ProductListDto, ProductFilterDto и т.д.

3. DbContext (AppDbContext)

4. Автоматический AutoMapper профиль

5. Generic Repository и Service

6. Сервис для доступа к IQueryable (глобальный доступ через DI)
Регистрация:
services.AddScoped<IDataQueryService, DataQueryService>();

8. Base Controller с фильтрацией, сортировкой и ListDto
Как использовать
Создать сущность Product (унаследовать от Entity)

Опционально создать DTO: ProductDto, ProductListDto, ProductFilterDto

Создать контроллер:

```public class ProductsController : BaseController<Product, ProductDto, ProductListDto, ProductFilterDto>
{
    public ProductsController(IRepository<Product> repo, IMapper mapper, IDataQueryService queryService)
        : base(repo, mapper, queryService)
    {
    }
}```

В Program.cs зарегистрировать сервисы и контекст:

services.AddDbContext<AppDbContext>(options => /* ... */);
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
services.AddScoped<IDataQueryService, DataQueryService>();
services.AddAutoMapper(typeof(AutoMapperProfileGenerator));

# Итог

Автоматический DbSet для всех Entity (через рефлексию в OnModelCreating)

Автоматический маппинг Entity ↔ DTO по имени без профилей

Базовый репозиторий с LINQ, async-методами и логическим удалением

Удобный сервис IDataQueryService с Query<T>() для любых LINQ запросов

Базовый контроллер с универсальным фильтром, сортировкой и пагинацией

Всё это — легко расширяется и подключается в любом проекте без лишних действий
