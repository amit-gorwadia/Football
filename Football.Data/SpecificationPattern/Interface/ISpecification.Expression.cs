using System;
using System.Linq.Expressions;

namespace Football.Data.SpecificationPattern.Interface
{
    public partial interface ISpecification<TEntity>
    {
        Expression<Func<TEntity, bool>> Expression { get; }
    }
}
