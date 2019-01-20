using System.Linq.Expressions;

namespace Football.Data.SpecificaitonPattern
{
    public partial class NotSpecification<TEntity>
    {
        public override bool IsSatisfiedBy(TEntity entity) => Expression.Compile().Invoke(entity);
    }
}
