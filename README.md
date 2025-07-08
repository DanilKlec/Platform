# 🔧 Универсальное ядро (Core) для C# проектов

Чистая архитектура для ASP.NET Core, WebAPI или Console-приложений — с автоматическим подключением сущностей, DTO, фильтрацией, CRUD и поддержкой LINQ-запросов без ручной настройки.

> 💡 Подходит для любого проекта, где нужно быстро начать без копипасты инфраструктуры.

## 🚀 Как начать использовать

1. Добавь сущность `Product` (унаследуй от `Entity`)
2. Добавь DTO (опционально):  
   - `ProductDto`  
   - `ProductListDto`  
   - `ProductFilterDto`
3. Создай контроллер:  
   ```csharp
   public class ProductsController : BaseController<Product, ProductDto, ProductListDto, ProductFilterDto>
   {
       public ProductsController(IRepository<Product> repo, IMapper mapper, IDataQueryService queryService)
           : base(repo, mapper, queryService) { }
   }
   
## ✅ Пример запроса к базе:
   ```csharp
    var items = await Query<Product>()
        .Where(p => p.Price > 100)
        .OrderByDescending(p => p.CreatedAt)
        .ToListAsync();
```

## 🔁 Автоматический маппинг
Тебе не нужно создавать профили вручную:
Если ты назвал DTO как ProductDto, ProductListDto, ProductFilterDto — маппинг произойдёт сам благодаря рефлексии и AutoMapperProfileGenerator.

builder.Services.AddCoreInfrastructure(builder.Configuration);

## 🧩 Структура и архитектура:
Entity: базовые поля, логическое удаление

DTO: DtoBase, ListDtoBase, FilterDtoBase

Repository: общий репозиторий без необходимости создания под каждую сущность

BaseController: поддержка фильтрации, сортировки, пагинации

AutoMapper: автоматическая конфигурация

LINQ: доступ через Query<T>() глобально или через IDataQueryService

Регистрация Query: ```services.AddScoped<IDataQueryService, DataQueryService>();```

## 📦 Установка и DI:
```csharp
services.AddDbContext<AppDbContext>(...);
services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
services.AddScoped<IDataQueryService, DataQueryService>();
services.AddAutoMapper(typeof(AutoMapperProfileGenerator));
// Регистрируем все сервисы ядра
builder.Services.AddCoreInfrastructure(builder.Configuration);
