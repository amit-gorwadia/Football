using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern.Interface
{
    public partial interface IRepository<TEntity>
    {
        IEnumerable<TEntity> Get(ISpecification<TEntity> predicate);

        IEnumerable<TEntity> Get(ISpecification<TEntity> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
    }
}
