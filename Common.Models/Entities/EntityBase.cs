namespace Common.Models.Entities
{
    public abstract class EntityBase<TId>
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public TId Id { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DateTime? CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdated { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedUTC { get; set; } = null;
    }

    public abstract class EntityBaseWithGuidId : EntityBase<Guid> { }
    public abstract class EntityBaseWithIntId : EntityBase<int> { }
}
