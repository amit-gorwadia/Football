using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Football.Data.SpecificationPattern.Interface;
using Microsoft.EntityFrameworkCore;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public virtual async Task<IEnumerable<TEntity>> GetAsync(ISpecification<TEntity> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            if (predicate.Expression == null)
                throw new ArgumentNullException(nameof(predicate.Expression));
            return await GetQuery().Where(predicate.Expression).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(ISpecification<TEntity> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {

            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            if (predicate.Expression == null)
                throw new ArgumentNullException(nameof(predicate.Expression));
            if (orderBy == null)
                throw new ArgumentNullException(nameof(orderBy));
            return await orderBy(GetQuery().Where(predicate.Expression)).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            return await GetQuery().Where(predicate).ToListAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            if (orderBy == null)
                throw new ArgumentNullException(nameof(orderBy));
            return await orderBy(GetQuery().Where(predicate)).ToListAsync();
        }
    }
}
