using Common.Extensions;

namespace Common.RuleTrees
{
    public class ExclusiveRangeSearchParameter : SearchParameterRule
    {
        public IComparable From { get; set; }
        public IComparable To { get; set; }

        public override async Task<bool> Passes()
        {
            bool result = false;
            if (ComparisonValue is IComparable comparisonValue)
            {
                result = comparisonValue.IsGreaterThan(From)
                && comparisonValue.IsLessThan(To);
            }

            return result && await RuleTree.PassesAnd(Children);
        }
    }

    public class ExclusiveRangeSearchParameter<T> : SearchParameterRule
    {
        public T From { get; set; }
        public T To { get; set; }

        public override async Task<bool> Passes()
        {
            bool result = false;
            if (ComparisonValue is IComparable<T> comparisonValue)
            {
                result = comparisonValue.IsGreaterThan(From)
                && comparisonValue.IsLessThan(To);
            }

            return result && await RuleTree.PassesAnd(Children);
        }
    }
}
