using System.Linq;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        protected virtual IQueryable<TEntity> GetQuery()
        {
            //IQueryable<TEntity> query =
            //    ((IObjectContextAdapter) DbContext).ObjectContext.CreateObjectSet<TEntity>(GetEntityName());

            //As per Article
            //http://blog.willbeattie.com/2011/02/specification-pattern-entity-framework.html
            //ObjectQuery<TEntity> query =
            //    ((IObjectContextAdapter) DbContext).ObjectContext.CreateObjectSet<TEntity>(GetEntityName());
            IQueryable<TEntity> query = dbSet;

            //var query =
            //    ((IObjectContextAdapter)DbContext).ObjectContext.CreateObjectSet<TEntity>(GetEntityName());

            return query;
        }
    }
}
