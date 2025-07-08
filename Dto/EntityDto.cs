using AutoMapper;
using Platform.Domain;

namespace Platform.Dto;

public abstract class EntityDto<TKey>
{
    public TKey Id { get; set; }
}

public class EntityDto : EntityDto<int> { }

// AutoMapper профиль для EntityBase <-> DtoBase
public class BaseMappingProfile<TEntity, TDto, TKey> : Profile 
    where TEntity : EntityBaseDomain<TKey> 
    where TDto : EntityDto<TKey>
{
    public BaseMappingProfile()
    {
        CreateMap<TEntity, TDto>().ReverseMap();
    }
}
