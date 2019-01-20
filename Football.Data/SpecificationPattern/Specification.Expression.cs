#region References
using System;
using System.Linq.Expressions;
#endregion

namespace Football.Data.SpecificaitonPattern
{
    public abstract partial class Specification<TEntity>
    {
        public virtual Expression<Func<TEntity, bool>> Expression => expression;
    }
}
