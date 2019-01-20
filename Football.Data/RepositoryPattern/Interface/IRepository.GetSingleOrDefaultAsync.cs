using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern.Interface
{
    public partial interface IRepository<TEntity>
    {
        Task<TEntity> GetSingleOrDefaultAsync(ISpecification<TEntity> predicate);

        Task<TEntity> GetSingleOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
