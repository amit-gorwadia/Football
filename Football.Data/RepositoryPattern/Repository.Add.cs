using System;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public virtual void Add(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentException(nameof(entity));
            dbSet.Add(entity);
            //DbContext.Set<TEntity>().Add(entity);
        }
    }
}
