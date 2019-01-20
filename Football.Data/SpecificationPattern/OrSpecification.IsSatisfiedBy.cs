namespace Football.Data.SpecificaitonPattern
{
    public partial class OrSpecification<TEntity>
    {
        public override bool IsSatisfiedBy(TEntity entity) => Expression.Compile().Invoke(entity);
    }
}
