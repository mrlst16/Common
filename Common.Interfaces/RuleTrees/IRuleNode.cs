namespace Common.Interfaces.RuleTrees
{
    public interface IRuleNode
    {
        IEnumerable<IRuleNode> Children { get; set; }
        Guid ID { get; set; }
        Guid ParentID { get; set; }
        Task<bool> Passes();
    }
}
