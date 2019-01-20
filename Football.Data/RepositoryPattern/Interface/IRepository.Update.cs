namespace Football.Data.RepositoryPattern.Interface
{
    public partial interface IRepository<TEntity>
    {
        void Update(TEntity entity);
    }
}
