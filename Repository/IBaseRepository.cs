using APEC.ProyectoFinal.API.Entities;
using System.Linq.Expressions;

namespace APEC.ProyectoFinal.API.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class, IEntity
    {
        Task<TEntity> Add(TEntity entity);

        Task<List<TEntity>> AddRange(List<TEntity> entity);

        Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression);

        void Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        Task<List<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression, bool asNoTracking = true);

        Task<TEntity> Get(int id);

        IQueryable<TEntity> GetAll();

        void Update(TEntity entity);
    }
}