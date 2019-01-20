using System;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.RepositoryPattern.Interface
{
    public partial interface IRepository<TEntity>
    {
        Task<TEntity> GetFirstOrDefaultAsync(ISpecification<TEntity> predicate);

        Task<TEntity> GetFirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate);
    }
}
