﻿using Common.Extensions;
using Common.Models.Enums;

namespace Common.RuleTrees.Comparison
{
    public class GenericComparisonRule<T2> : ComparisonRule<T2>
        where T2 : IComparable<T2>
    {

        public GenericComparisonRule() : base()
        {
        }

        public GenericComparisonRule(T2 ownValue) : base(ownValue)
        {
        }

        public GenericComparisonRule(T2 ownValue, T2 comparisonValue) : base(ownValue, comparisonValue)
        {
        }

        public override async Task<bool> Passes()
        {
            bool result = false;

            if (ComparisonValue is T2 comparisonValue)
            {
                switch (Operator)
                {
                    case ComparisonOperatorEnum.LessThan:
                        result = OwnValue.IsLessThan<T2>(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.LessThanOrEqualTo:
                        result = OwnValue.IsLessThanOrEqualTo<T2>(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.EqualTo:
                        result = OwnValue.IsEqualTo<T2>(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.GreaterThanOrEqualTo:
                        result = OwnValue.IsGreaterThanOrEqualTo<T2>(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.GreaterThan:
                        result = OwnValue.IsGreaterThan<T2>(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.NotEqualTo:
                        result = OwnValue.IsNotEqualTo<T2>(comparisonValue);
                        break;
                    default:
                        result = OwnValue.IsEqualTo<T2>(comparisonValue);
                        break;
                }
            }
            return result
                && await RuleTree.PassesAnd(Children);
        }
    }

    public class GenericComparisonRule : ComparisonRule<IComparable>
    {
        public GenericComparisonRule() : base()
        {
        }

        public GenericComparisonRule(IComparable ownValue) : base(ownValue)
        {
        }

        public GenericComparisonRule(IComparable ownValue, IComparable comparisonValue) : base(ownValue, comparisonValue)
        {
        }

        public override async Task<bool> Passes()
        {
            bool result = false;

            if (ComparisonValue is IComparable comparisonValue)
            {
                switch (Operator)
                {
                    case ComparisonOperatorEnum.LessThan:
                        result = OwnValue.IsLessThan(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.LessThanOrEqualTo:
                        result = OwnValue.IsLessThanOrEqualTo(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.EqualTo:
                        result = OwnValue.IsEqualTo(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.GreaterThanOrEqualTo:
                        result = OwnValue.IsGreaterThanOrEqualTo(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.GreaterThan:
                        result = OwnValue.IsGreaterThan(comparisonValue);
                        break;
                    case ComparisonOperatorEnum.NotEqualTo:
                        result = OwnValue.IsNotEqualTo(comparisonValue);
                        break;
                    default:
                        result = OwnValue.IsEqualTo(comparisonValue);
                        break;
                }
            }
            return result
                && await RuleTree.PassesAnd(Children);
        }


    }

}
