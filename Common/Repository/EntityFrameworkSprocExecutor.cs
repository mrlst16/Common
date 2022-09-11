using Common.Interfaces.Repository;
using Microsoft.EntityFrameworkCore;

namespace Common.Repository
{
    public class EntityFrameworkSprocExecutor<D, R> : ISprocExecutor<R>
        where D : DbContext
    {
        private readonly D _context;

        public EntityFrameworkSprocExecutor(
            D context
            )
        {
            _context = context;
        }

        public Task<R> ExecuteAsync(string sproc, IEnumerable<KeyValuePair<string, string>> parameters)
        {
            _context.Database.ExecuteSqlRawAsync
        }
    }
}
