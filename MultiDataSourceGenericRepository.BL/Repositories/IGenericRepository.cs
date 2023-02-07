using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace MultiDataSourceGenericRepository.BL.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");
        TEntity GetByID(object id);
        TEntity Insert(TEntity entity);
        void Upsert(TEntity entity);
        void Update(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
    }
}