using System;
using System.Linq.Expressions;

namespace Football.Extension.LinqExpression
{
    public static partial class PredicateBuilder
    {
        public static Expression<Func<T, bool>> Not<T>(this Expression<Func<T, bool>> expression) => Expression.Lambda<Func<T, bool>>(Expression.Not(expression.Body), expression.Parameters);
    }
}
