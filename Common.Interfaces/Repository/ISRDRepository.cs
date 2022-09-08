using Common.Models.Entities;

namespace Common.Interfaces.Repository
{
    public interface ISRDRepository<T, TId>
    where T : EntityBase<TId>
    {
        Task<TId> SaveAsync(T obj);
        Task<IEnumerable<TId>> SaveAsync(IEnumerable<T> obj);
        Task<T> ReadAsync(TId id);
        Task<bool> DeleteAsync(TId id);
        Task<IEnumerable<T>> ReadAsync(Func<T, bool> predicate);
    }
}
