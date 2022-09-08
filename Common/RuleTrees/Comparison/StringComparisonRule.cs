namespace Common.RuleTrees.Comparison
{
    public class StringComparisonRule : ComparisonRule<string>
    {
        private const string NonApplicableOperatorMessage = "Only equals and not-equals operators are valid for StringComparisonRule";

        public override async Task<bool> Passes()
        {
            var result = false;

            switch (Operator)
            {
                case Common.Models.Enums.ComparisonOperatorEnum.LessThan:
                case Common.Models.Enums.ComparisonOperatorEnum.LessThanOrEqualTo:
                case Common.Models.Enums.ComparisonOperatorEnum.GreaterThanOrEqualTo:
                case Common.Models.Enums.ComparisonOperatorEnum.GreaterThan:
                    throw new System.Exception(NonApplicableOperatorMessage);
                case Common.Models.Enums.ComparisonOperatorEnum.EqualTo:
                    result = OwnValue == ComparisonValue.ToString();
                    break;
                case Common.Models.Enums.ComparisonOperatorEnum.NotEqualTo:
                    result = OwnValue != ComparisonValue.ToString();
                    break;
                default:
                    result = OwnValue == ComparisonValue.ToString();
                    break;
            }

            return result && await RuleTree.PassesAnd(Children);
        }

        public StringComparisonRule() : base()
        {

        }

        public StringComparisonRule(string comparisonValue) : base(comparisonValue) { }

        public StringComparisonRule(string ownValue, string comparisonValue) : base(ownValue, comparisonValue)
        {
        }
    }
}
