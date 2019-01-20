using System;
using System.Linq.Expressions;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern.Interface
{
    public partial interface IRepository<TEntity>
    {
        void Delete(TEntity entity);

        void Delete(ISpecification<TEntity> predicate);

        void Delete(Expression<Func<TEntity, bool>> predicate);
    }
}
