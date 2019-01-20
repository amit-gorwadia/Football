using Football.Data.SpecificationPattern.Interface;
using Football.Extension.LinqExpression;

namespace Football.Data.SpecificaitonPattern
{
    public partial class NotSpecification<TEntity> : Specification<TEntity>
    {
        public NotSpecification(ISpecification<TEntity> predicate) => expression = predicate.Expression.Not();
    }
}
