﻿using System;
using System.Linq.Expressions;

namespace Football.Extension.LinqExpression
{
    public static partial class PredicateBuilder
    {
        public static Expression<Func<T, bool>> True<T>() => param => true;
    }
}
