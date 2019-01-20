using Football.Data.SpecificationPattern.Interface;

namespace Football.Data.SpecificaitonPattern
{
    public abstract partial class Specification<TEntity>
    {
        public static ISpecification<TEntity> operator !(Specification<TEntity> predicate) => new NotSpecification<TEntity>(predicate);
    }
}
