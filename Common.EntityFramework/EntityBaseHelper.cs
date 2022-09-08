using Common.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Common.EntityFramework
{
    public class EntityBaseHelper<T, Tid>
        where T : EntityBase<Tid>
        where Tid: IEquatable<Tid>
    {
        private readonly DbContext _context;

        protected EntityBaseHelper(
            DbContext context
            )
        {
            _context = context;
        }

        public virtual async Task<T> Save(T source)
        {
            var set = _context.Set<T>();
            var existing = await set.SingleOrDefaultAsync(x => x.Id.Equals(source.Id));

            if (existing == null)
            {
                var entryEntity = await set.AddAsync(source);
                await _context.SaveChangesAsync();
                return entryEntity.Entity;
            }
            else
            {
                set.Update(source);
                return source;
            }
        }


    }
}
