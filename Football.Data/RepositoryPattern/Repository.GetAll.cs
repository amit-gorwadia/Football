using System;
using System.Collections.Generic;
using System.Linq;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public virtual IEnumerable<TEntity> GetAll()
        {
            return GetQuery().AsEnumerable();
        }

        public virtual IEnumerable<TEntity> GetAll(
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {
            if (orderBy == null)
                throw new ArgumentNullException(nameof(orderBy));
            return orderBy(GetQuery()).AsEnumerable();
        }
    }
}
