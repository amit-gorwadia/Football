using Microsoft.EntityFrameworkCore;

namespace Football.Data.RepositoryPattern
{
    public partial class Repository<TEntity>
    {
        private DbContext DbContext => context;
    }
}
