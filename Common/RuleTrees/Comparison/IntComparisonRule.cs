namespace Common.RuleTrees.Comparison
{
    public class IntComparisonRule : ComparisonRule<int>
    {
        public override async Task<bool> Passes()
        {
            var result = false;
            switch (Operator)
            {
                case Common.Models.Enums.ComparisonOperatorEnum.LessThan:
                    result = OwnValue < (int)ComparisonValue;
                    break;
                case Common.Models.Enums.ComparisonOperatorEnum.LessThanOrEqualTo:
                    result = OwnValue >= (int)ComparisonValue;
                    break;
                case Common.Models.Enums.ComparisonOperatorEnum.EqualTo:
                    result = OwnValue == (int)ComparisonValue;
                    break;
                case Common.Models.Enums.ComparisonOperatorEnum.GreaterThanOrEqualTo:
                    result = OwnValue >= (int)ComparisonValue;
                    break;
                case Common.Models.Enums.ComparisonOperatorEnum.GreaterThan:
                    result = OwnValue >= (int)ComparisonValue;
                    break;
                case Common.Models.Enums.ComparisonOperatorEnum.NotEqualTo:
                    result = OwnValue != (int)ComparisonValue;
                    break;
                default:
                    result = OwnValue == (int)ComparisonValue;
                    break;
            }
            return result && await RuleTree.PassesAnd(Children);
        }
    }


}
