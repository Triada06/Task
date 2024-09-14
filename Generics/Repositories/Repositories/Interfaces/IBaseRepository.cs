
using Domain.Common;

namespace Repositories.Repositories.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetBytId(int Id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}
