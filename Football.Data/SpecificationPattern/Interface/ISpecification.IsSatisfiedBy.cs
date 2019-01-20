namespace Football.Data.SpecificationPattern.Interface
{
    public partial interface ISpecification<TEntity>
    {
        bool IsSatisfiedBy(TEntity entity);
    }
}
