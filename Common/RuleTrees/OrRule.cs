namespace Common.RuleTrees
{
    public class OrRule : RuleNode
    {
        public OrRule()
            : base() { }

        public OrRule(params RuleNode[] ruleNodes)
            : base(ruleNodes) { }

        public override async Task<bool> Passes()
            => await RuleTree.PassesOr(Children);
    }
}
