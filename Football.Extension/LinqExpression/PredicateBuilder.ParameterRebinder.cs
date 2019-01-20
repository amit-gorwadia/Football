using System.Collections.Generic;
using System.Linq.Expressions;

namespace Football.Extension.LinqExpression
{
    public static partial class PredicateBuilder
    {
        class ParameterRebinder : ExpressionVisitor
        {
            readonly Dictionary<ParameterExpression, ParameterExpression> _map;

            ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map) => _map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();

            public static Expression ReplaceParameters(Dictionary<ParameterExpression, ParameterExpression> map, Expression exp) => new ParameterRebinder(map).Visit(exp);

            protected override Expression VisitParameter(ParameterExpression p)
            {
                ParameterExpression replacement;

                if (_map.TryGetValue(p, out replacement))
                {
                    p = replacement;
                }

                return base.VisitParameter(p);
            }
        }
    }
}
