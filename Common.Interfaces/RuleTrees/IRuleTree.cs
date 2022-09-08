namespace Common.Interfaces.RuleTrees
{
    public interface IRuleTree
    {
        IRuleNode BaseNode { get; set; }
        Task<bool> Passes();
    }
}
