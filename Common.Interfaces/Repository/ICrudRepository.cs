using Common.Models.Entities;
using System.Linq.Expressions;

namespace Common.Interfaces.Repository
{
    public interface ICrudRepository<T>
    {
        Task Create(IEnumerable<T> items);
        Task Create(T items);
        Task<IEnumerable<T>> Read(Expression<Func<T, bool>> filter);
        Task<IEnumerable<T>> Read(SearchRequestBase<T> searchRequest);
        Task<T> First(Expression<Func<T, bool>> filter);
        Task<(bool, T)> Update(T item, Expression<Func<T, bool>> filter);
        Task<bool> Delete(Expression<Func<T, bool>> expression);
        Task<bool> DeleteBulk(Expression<Func<T, bool>> filter);
    }
}
