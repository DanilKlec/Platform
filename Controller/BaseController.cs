using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Platform.Domain;
using Platform.Dto;
using Platform.Repository;
using Platform.Services;

namespace Platform.Controller;


[ApiController]
[Route("api/[controller]")]
public abstract class BaseController<TEntity, TDto, TListDto, TFilterDto> : ControllerBase
    where TEntity : EntityDomain
    where TDto : EntityDto
    where TListDto : EntityListDto
    where TFilterDto : EntityFilterDto
{
    protected readonly IRepository<TEntity> _repo;
    protected readonly IMapper _mapper;
    protected readonly IDataQueryService _queryService;

    public BaseController(IRepository<TEntity> repo, IMapper mapper, IDataQueryService queryService)
    {
        _repo = repo;
        _mapper = mapper;
        _queryService = queryService;
    }
}
