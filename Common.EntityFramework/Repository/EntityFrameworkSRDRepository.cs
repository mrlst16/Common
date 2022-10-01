using Common.Interfaces.Repository;
using Common.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Common.EntityFramework.Repository
{
    public class EntityFrameworkSRDRepository<D, T, TId> : ISRDRepository<T, TId>
        where D : DbContext
        where T : EntityBase<TId>
        where TId : IEquatable<TId>
    {
        private readonly D _context;

        public EntityFrameworkSRDRepository(
            D context
            )
        {
            _context = context;
        }

        public async Task<TId> SaveAsync(T obj)
        {
            TId result = default(TId);

            var set = _context.Set<T>();

            //If the id is set to default, force add


            //If it exists
            var entityResult =
                (set.Any(x => x.Id.Equals(obj.Id))) //Test if the object exists by Id
                    ? set.Update(obj) //If it exists, update it
                        : await set.AddAsync(obj); // if it doesn't exist, add it

            await _context.SaveChangesAsync();
            return entityResult.Entity.Id;
        }

        public async Task<IEnumerable<TId>> SaveAsync(IEnumerable<T> obj)
        {
            TId[] result = new TId[obj.Count()];
            var allIds = obj.Select(x => x.Id);

            var set = _context.Set<T>();

            var updates = set.Where(x => allIds.Contains(x.Id));
            set.UpdateRange(updates);
            var additions = set.Where(x => x.Id.Equals(Guid.Empty) || !allIds.Contains(x.Id));
            await set.AddRangeAsync(additions);

            return result;
        }

        public async Task<T> ReadAsync(TId id)
            => (await _context.Set<T>()
                    ?.FirstOrDefaultAsync(x => x.Id.Equals(id))
                ?? default(T));

        public async Task<bool> DeleteAsync(TId id)
        {
            var set = _context.Set<T>();
            var obj = await set.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (obj == null) return false;

            set.Remove(obj);

            await _context.SaveChangesAsync();
            return false;
        }

        //TODO: Look into Query Filters
        public async Task<IEnumerable<T>> ReadAsync(Func<T, bool> predicate)
            => _context.Set<T>().Where(x => predicate(x) && x.DeletedUTC == null);
    }
}
