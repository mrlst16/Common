namespace Common.RuleTrees
{
    public class FuncRule : RuleNode
    {
        private readonly Func<bool> _func;

        public FuncRule(
            Func<bool> func
            )
        {
            _func = func;
        }

        public override async Task<bool> Passes()
             => _func() && await RuleTree.PassesAnd(Children);
    }
}
