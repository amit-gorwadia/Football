using System;
using System.Collections.Generic;
using System.Linq;

namespace Football.Data.RepositoryPattern.Interface
{
    public partial interface IRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> GetAll(Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
    }
}
