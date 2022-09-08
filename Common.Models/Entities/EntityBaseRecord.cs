namespace Common.Models.Entities
{
    public abstract record EntityBaseRecord
    {
        public int Id { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.UtcNow;
        public DateTime? LastUpdated { get; set; } = DateTime.UtcNow;
        public DateTime? DeletedUTC { get; set; } = null;
    }
}
