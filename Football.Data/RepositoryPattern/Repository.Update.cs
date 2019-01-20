using Microsoft.EntityFrameworkCore;
using System;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public virtual void Update(TEntity entity)
        {
            if (entity == null)
                throw new ArgumentException(nameof(entity));
            context.Entry(entity).State = EntityState.Modified;
            //DbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
