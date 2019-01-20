using Football.Data.SpecificationPattern.Interface;
using Football.Extension.LinqExpression;

namespace Football.Data.SpecificaitonPattern
{
    public partial class AndSpecification<TEntity> : Specification<TEntity>
    {
        //private ISpecificationPattern<TEntity> leftSpecification;
        //private ISpecificationPattern<TEntity> rightSpecification;
        //private Func<TEntity, bool> function = null;

        public AndSpecification(ISpecification<TEntity> left, ISpecification<TEntity> right)
        {
            //leftSpecification = left;
            // rightSpecification = right;

            //function = (Func<TEntity, bool>) Delegate.Combine(left.Expression.Compile(), right.Expression.Compile());
            expression = left.Expression.And(right.Expression);
        }
    }
}
