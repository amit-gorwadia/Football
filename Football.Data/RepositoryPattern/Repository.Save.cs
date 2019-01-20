using System;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public virtual void Save(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentException(nameof(entity));
            context.SaveChanges();
            //DbContext.SaveChanges();
        }
    }
}
