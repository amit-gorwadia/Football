using System;
using System.Linq;
using System.Linq.Expressions;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public TEntity GetFirstOrDefault(ISpecification<TEntity> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            if (predicate.Expression == null)
                throw new ArgumentNullException(nameof(predicate));
            return GetQuery().FirstOrDefault(predicate.Expression);
        }

        public TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));
            return GetQuery().FirstOrDefault(predicate);
        }
    }
}
