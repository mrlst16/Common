namespace Common.Interfaces.Repository
{
    public interface ISprocExecutor<Y>
    {
        public Task<T> ExecuteAsync<T>(Y proc);
    }
}
