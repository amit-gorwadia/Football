using System;
using System.Linq.Expressions;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern.Interface
{
    public partial interface IRepository<TEntity>
    {
        TEntity GetFirstOrDefault(ISpecification<TEntity> predicate);

        TEntity GetFirstOrDefault(Expression<Func<TEntity, bool>> predicate);
    }
}
