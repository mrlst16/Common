namespace Common.Interfaces.RuleTrees
{
    public interface IRuleTreeValueProvider
    {
        Task<object> GetValue(string key);
    }
}
