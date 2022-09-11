namespace Common.Interfaces.Repository
{
    /// <summary>
    /// Executes a stored procedure on the database
    /// </summary>
    /// <typeparam name="R">Return Type</typeparam>
    public interface ISprocExecutor<R>
    {
        public Task<R> ExecuteAsync(string sproc, IEnumerable<KeyValuePair<string, string>> parameters);
    }
}
