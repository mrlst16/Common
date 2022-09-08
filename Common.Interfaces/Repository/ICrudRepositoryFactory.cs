namespace Common.Interfaces.Repository
{
    public interface ICrudRepositoryFactory
    {
        ICrudRepository<T> Get<T>();
    }
}
