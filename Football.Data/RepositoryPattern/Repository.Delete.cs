using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public virtual void Delete(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));
            dbSet.Remove(entity);
            //DbContext.Set<TEntity>().Remove(entity);
        }

        public virtual void Delete(ISpecification<TEntity> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            var entities = GetQuery().Where(predicate.Expression).AsEnumerable();
            if (entities != null)
            {
                var enumerable = entities as IList<TEntity> ?? entities.ToList();
                if (enumerable.Count > 0)
                    dbSet.RemoveRange(enumerable);
                //DbContext.Set<TEntity>().RemoveRange(enumerable);
            }
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            var entities = GetQuery().Where(predicate).AsEnumerable();
            if (entities != null)
            {
                var enumerable = entities as IList<TEntity> ?? entities.ToList();
                if (enumerable.Count > 0)
                    dbSet.RemoveRange(enumerable);
                //DbContext.Set<TEntity>().RemoveRange(enumerable);
            }
        }
    }
}
