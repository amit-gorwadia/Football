using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await GetQuery().ToArrayAsync();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy)
        {
            return await orderBy(GetQuery()).ToListAsync();
        }
    }
}
