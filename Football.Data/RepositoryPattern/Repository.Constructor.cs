using System;
using Football.Data.RepositoryPattern.Interface;
using Microsoft.EntityFrameworkCore;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private DbContext context;
        private DbSet<TEntity> dbSet;

        #region Constructor

        public Repository(DbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            dbSet = this.context.Set<TEntity>();
        }
        #endregion
    }
}
