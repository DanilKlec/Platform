using AutoMapper;
using Platform.Domain;
using Platform.Dto;
using System.Reflection;

namespace Platform.AutoMapper;

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

