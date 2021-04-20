using System.Collections.Generic;
using System.Threading.Tasks;
using OwensDoug.Core.Entity;
using OwensDoug.Core.Specification;

namespace OwensDoug.Core.Repository
{
    public interface IRepository<T> where T : IEntity
    {
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> Get(ISpecification<T> spec);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task<T> Delete(int id);
        Task<int> Count(ISpecification<T> spec);
    }
}
