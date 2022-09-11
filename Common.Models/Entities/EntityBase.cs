namespace Common.Models.Entities
{
    public abstract class EntityBase<TId>
    {
        public TId? Id { get; set; } = default(TId);
        public DateTime? CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdated { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedUTC { get; set; } = null;

        public EntityBase<TId> SoftDelete()
        {
            DeletedUTC = DateTime.UtcNow;
            return this;
        }
    }

    public abstract class EntityBaseWithGuidId : EntityBase<Guid> { }
    public abstract class EntityBaseWithIntId : EntityBase<int> { }
}
