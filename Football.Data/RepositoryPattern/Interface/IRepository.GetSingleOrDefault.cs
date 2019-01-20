using System;
using System.Linq.Expressions;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern.Interface
{
    public partial interface IRepository<TEntity>
    {
        TEntity GetSingleOrDefault(ISpecification<TEntity> predicate);

        TEntity GetSingleOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}
