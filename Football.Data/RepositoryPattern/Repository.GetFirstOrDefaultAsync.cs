using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Football.Data.SpecificationPattern.Interface;
using Microsoft.EntityFrameworkCore;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public Task<TEntity> GetFirstOrDefaultAsync(ISpecification<TEntity> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            if (predicate.Expression == null)
                throw new ArgumentNullException(nameof(predicate.Expression));
            return GetQuery().FirstOrDefaultAsync(predicate.Expression);
        }

        public Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            return GetQuery().FirstOrDefaultAsync(predicate);
        }
    }
}
