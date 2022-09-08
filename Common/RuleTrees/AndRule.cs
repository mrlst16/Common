namespace Common.RuleTrees
{
    public class AndRule : RuleNode
    {
        public AndRule()
            : base() { }

        public AndRule(params RuleNode[] ruleNodes)
            : base(ruleNodes) { }

        public override async Task<bool> Passes()
            => await RuleTree.PassesAnd(Children);
    }
}
