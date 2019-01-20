#region References
using System;
using System.Linq.Expressions;
using Football.Data.SpecificationPattern.Interface;
#endregion

namespace Football.Data.SpecificaitonPattern
{
    public abstract partial class Specification<TEntity> : ISpecification<TEntity>
    {
        protected Expression<Func<TEntity, bool>> expression;

        protected Specification(Expression<Func<TEntity, bool>> expression)
        {
            this.expression = expression;
        }

        protected Specification()
        { }
    }
}
