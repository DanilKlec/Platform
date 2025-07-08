using Microsoft.EntityFrameworkCore;
using Platform.Domain;
using System.Linq.Expressions;
using System.Reflection;

namespace Platform.Application;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var entityTypes = Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && typeof(Entity).IsAssignableFrom(t));

        foreach (var type in entityTypes)
        {
            modelBuilder.Entity(type);
            modelBuilder.Entity(type).HasQueryFilter(Expression.Lambda(
                Expression.Equal(
                    Expression.Property(Expression.Parameter(type, "e"), nameof(Entity.IsDeleted)),
                    Expression.Constant(false)
                ),
                Expression.Parameter(type, "e")
            ));
        }

        base.OnModelCreating(modelBuilder);
    }
}

