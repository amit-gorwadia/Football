using System;
using System.Linq.Expressions;

namespace Football.Extension.LinqExpression
{
    public static partial class PredicateBuilder
    {
        public static Expression<Func<T, bool>> Create<T>(Expression<Func<T, bool>> predicate) => predicate;
    }
}
