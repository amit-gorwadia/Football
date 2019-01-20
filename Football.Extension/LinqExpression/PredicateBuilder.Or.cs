using System;
using System.Linq.Expressions;

namespace Football.Extension.LinqExpression
{
    public static partial class PredicateBuilder
    {
        public static Expression<Func<T, bool>> Or<T>(this Expression<Func<T, bool>> first, Expression<Func<T, bool>> second) => first.Compose(second, Expression.OrElse);
    }
}
