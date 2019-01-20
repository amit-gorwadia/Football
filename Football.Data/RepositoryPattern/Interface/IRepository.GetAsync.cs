using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern.Interface
{
    public partial interface IRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAsync(ISpecification<TEntity> predicate);

        Task<IEnumerable<TEntity>> GetAsync(ISpecification<TEntity> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);

        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate);

        Task<IEnumerable<TEntity>> GetAsync(Expression<Func<TEntity, bool>> predicate,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy);
    }
}
