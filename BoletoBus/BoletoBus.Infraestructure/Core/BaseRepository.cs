
using BoletoBus.Domain.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BoletoBus.Infraestructure.Core
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly DbContext context;
        private DbSet<TEntity> _entities;

        protected BaseRepository(DbContext context)
        {
            this.context = context;
            _entities = this.context.Set<TEntity>();
        }

        public async Task<bool> Exists(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.AnyAsync(filter);
        }

        public async Task<TEntity> Get(int Id)
        {
            return await _entities.FindAsync(Id);
        }

        public async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.Where(filter).ToListAsync();
        }

        public async Task Save(TEntity entity)
        {
            _entities.Add(entity);
            await context.SaveChangesAsync();
        }

        public async Task Save(List<TEntity> entities)
        {
            _entities.AddRange(entities);
            await context.SaveChangesAsync();
        }

        public async Task Update(TEntity entity)
        {
            _entities.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task Update(List<TEntity> entities)
        {
            _entities.UpdateRange(entities);
            await context.SaveChangesAsync();
        }
    }
}
