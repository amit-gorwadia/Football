using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public virtual IEnumerable<TEntity> Get(ISpecification<TEntity> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            if (predicate.Expression == null)
                throw new ArgumentNullException(nameof(predicate.Expression));
            return GetQuery().Where(predicate.Expression).AsEnumerable();
        }

        public virtual IEnumerable<TEntity> Get(ISpecification<TEntity> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            if (predicate.Expression == null)
                throw new ArgumentNullException(nameof(predicate.Expression));
            if (orderBy == null)
                throw new ArgumentNullException(nameof(orderBy));
            return orderBy(GetQuery().Where(predicate.Expression)).AsEnumerable();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            return GetQuery().Where(predicate).AsEnumerable();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            if (orderBy == null)
                throw new ArgumentNullException(nameof(orderBy));
            return orderBy(GetQuery().Where(predicate));
        }
    }
}
