using APEC.ProyectoFinal.API.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace APEC.ProyectoFinal.API.Repository
{
    public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity> where TEntity : class, IEntity
      where TContext : DbContext
    {
        private readonly TContext _context;

        public BaseRepository(TContext context)
        {
            _context = context;
        }

        public IQueryable<TEntity> GetAll() => _context.Set<TEntity>();

        public async Task<TEntity> Get(int id) => await _context.Set<TEntity>().FindAsync(id);

        public async Task<List<TEntity>> FindByConditionAsync(Expression<Func<TEntity, bool>> expression, bool asNoTracking = true)
        {
            var entity = _context.Set<TEntity>();

            if (asNoTracking)
                return await entity.Where(expression).AsNoTracking().ToListAsync();

            return await entity.Where(expression).ToListAsync();
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression) => await _context.Set<TEntity>().AnyAsync(expression);

        public async Task<TEntity> Add(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<List<TEntity>> AddRange(List<TEntity> entity)
        {
            await _context.Set<TEntity>().AddRangeAsync(entity);
            return entity;
        }

        public void Update(TEntity entity) => _context.Entry(entity).State = EntityState.Modified;

        public void Delete(TEntity entity) => _context.Set<TEntity>().Remove(entity);

        public void DeleteRange(IEnumerable<TEntity> entities) => _context.Set<TEntity>().RemoveRange(entities);
    }
}