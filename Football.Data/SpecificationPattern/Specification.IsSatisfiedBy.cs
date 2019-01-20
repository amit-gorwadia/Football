using System.Linq;

namespace Football.Data.SpecificaitonPattern
{
    public abstract partial class Specification<TEntity>
    {
        public virtual bool IsSatisfiedBy(TEntity entity) => new[] { entity }.AsQueryable().Any(expression);
    }
}
