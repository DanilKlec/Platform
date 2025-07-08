using AutoMapper;
using Platform.Domain;

namespace Platform.Dto;

public abstract class DtoBase<TKey>
{
    public TKey Id { get; set; }
}

public class DtoBase : DtoBase<int> { }

// AutoMapper профиль для EntityBase <-> DtoBase
public class BaseMappingProfile<TEntity, TDto, TKey> : Profile 
    where TEntity : EntityBase<TKey> 
    where TDto : DtoBase<TKey>
{
    public BaseMappingProfile()
    {
        CreateMap<TEntity, TDto>().ReverseMap();
    }
}
