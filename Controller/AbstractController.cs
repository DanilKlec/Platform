using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Platform.Domain;
using Platform.Dto;
using Platform.Repository;
using Platform.Services;
using System.Linq.Expressions;

namespace Platform.Controller;

[ApiController]
public abstract class AbstractController<TEntity, TDto, TListDto, TFilterDto> : BaseController<TEntity, TDto, TListDto, TFilterDto>
    where TEntity : EntityDomain
    where TDto : EntityDto
    where TListDto : EntityListDto
    where TFilterDto : EntityFilterDto
{
    protected AbstractController(IServiceProvider provider) : base(provider.GetRequiredService<IRepository<TEntity>>(), provider.GetRequiredService<IMapper>(), provider.GetRequiredService<IDataQueryService>()) { }

    [HttpGet]
    public async Task<IEnumerable<TListDto>> PostQuery([FromQuery] TFilterDto? filter = null)
    {
        var query = _queryService.Query<TEntity>();

        if (filter != null)
        {
            var props = typeof(TFilterDto).GetProperties();
            foreach (var prop in props)
            {
                if (prop.Name is "Page" or "PageSize" or "Search" or "SortBy" or "Desc") continue;
                var value = prop.GetValue(filter);
                if (value == null) continue;

                var param = Expression.Parameter(typeof(TEntity), "x");
                var member = Expression.PropertyOrField(param, prop.Name);
                var constant = Expression.Constant(value);
                var equal = Expression.Equal(member, constant);
                var lambda = Expression.Lambda<Func<TEntity, bool>>(equal, param);

                query = query.Where(lambda);
            }

            if (!string.IsNullOrWhiteSpace(filter.SortBy))
            {
                var param = Expression.Parameter(typeof(TEntity), "x");
                var prop = Expression.PropertyOrField(param, filter.SortBy);
                var lambda = Expression.Lambda(prop, param);
                query = query.OrderByDynamic(filter.SortBy, filter.Desc);
            }

            if (filter.Page is int page && filter.PageSize is int size)
                query = query.Skip((page - 1) * size).Take(size);
        }

        var result = await query.ToListAsync();
        return result.Select(_mapper.Map<TListDto>);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<TDto>> GetEntity(int id)
    {
        var entity = await _repo.FirstOrDefaultAsync(x => x.Id == id);
        if (entity == null) return NotFound();
        return _mapper.Map<TDto>(entity);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TDto dto)
    {
        var entity = _mapper.Map<TEntity>(dto);
        await _repo.AddAsync(entity);
        return CreatedAtAction(nameof(GetEntity), new { id = entity.Id }, dto);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> SaveDto(int id, [FromBody] TDto dto)
    {
        if (dto.Id != id) return BadRequest();
        var entity = _mapper.Map<TEntity>(dto);
        await _repo.UpdateAsync(entity);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _repo.DeleteByIdAsync(id);
        return NoContent();
    }
}
