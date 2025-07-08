namespace Platform.Domain;

public abstract class EntityBaseDomain<TKey>
{
    public TKey Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public bool IsDeleted { get; set; } = false;
}

public abstract class EntityDomain : EntityBaseDomain<int> { }
