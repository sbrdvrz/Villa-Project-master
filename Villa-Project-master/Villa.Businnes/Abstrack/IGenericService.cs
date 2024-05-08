using MongoDB.Bson;
using System.Linq.Expressions;
using System.Runtime.Serialization;

namespace Villa.Businnes.Abstrack
{
    public interface IGenericService<T> where T : class
    {
        Task TCreateAsync(T entity);
        Task TUpdateAsync(T entity);
        Task TDeleteAsync(ObjectId id);
        Task<List<T>> TGetListAsync();
        Task<T> TGetByIdAsync(ObjectId id);
        Task<int> TCountAsync();
        Task<List<T>> TGetFilteredListAsync(Expression<Func<T, bool>> filter);
    }
}
