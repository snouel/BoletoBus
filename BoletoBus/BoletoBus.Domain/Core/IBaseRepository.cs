using System.Linq.Expressions;

namespace BoletoBus.Domain.Core
{

    //<TEntity> where TEntity : class Nos dice que TEntity debe ser una clase, se le conoce como restriccion generica
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task Save(TEntity entity);
        Task Save(List<TEntity> entities);
        Task Update(TEntity entity);
        Task Update(List<TEntity> entities);
        Task<TEntity> Get(int Id);
        Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter);
        Task<bool> Exists(Expression<Func<TEntity, bool>> filter);
    }
}
