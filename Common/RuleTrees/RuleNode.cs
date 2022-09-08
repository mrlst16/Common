using Common.Interfaces.RuleTrees;

namespace Common.RuleTrees
{
    public abstract class RuleNode : IRuleNode
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public Guid ParentID { get; set; }
        private List<IRuleNode> _children = new List<IRuleNode>();
        public IEnumerable<IRuleNode> Children
        {
            get
            {
                return _children;
            }
            set
            {
                foreach (var child in value)
                {
                    child.ParentID = ID;
                    _children.Add(child);
                }
            }
        }

        public abstract Task<bool> Passes();

        protected RuleNode() { }

        protected RuleNode(params RuleNode[] rules)
        {
            Children = rules.ToList();
        }
    }
}
