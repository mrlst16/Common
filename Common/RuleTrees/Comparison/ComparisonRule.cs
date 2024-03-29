﻿using Common.Models.Enums;

namespace Common.RuleTrees.Comparison
{
    public abstract class ComparisonRule<T> : SearchParameterRule
    {
        public string Type { get; set; }
        public T OwnValue { get; set; }

        public ComparisonOperatorEnum Operator { get; set; }

        protected ComparisonRule() : base()
        {
        }

        protected ComparisonRule(T ownValue)
        {
            OwnValue = ownValue;
        }

        protected ComparisonRule(T ownValue, T comparisonValue)
        {
            OwnValue = ownValue;
            ComparisonValue = comparisonValue;
        }
    }
}
