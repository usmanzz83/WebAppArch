using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebCore.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        // Marks an entity as new
        void Add(TEntity entity);

        // Marks an entity as modified
        void Update(TEntity entity);

        // Marks an entity to be removed
        void Delete(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where);

        // Get an entity by int id
        TEntity GetById(int id);

        // Get an entity using delegate
        TEntity Get(Expression<Func<TEntity, bool>> where);

        // Gets all entities of type T
        IEnumerable<TEntity> GetAll();

        // Gets entities using delegate
        IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);
    }
}
