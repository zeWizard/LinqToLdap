﻿/*
 * LINQ to LDAP
 * http://linqtoldap.codeplex.com/
 * 
 * Copyright Alan Hatter (C) 2010-2014
 
 * 
 * This project is subject to licensing restrictions. Visit http://linqtoldap.codeplex.com/license for more information.
 */

using System.Linq.Expressions;

namespace LinqToLdap.Visitors
{
    internal class NullVisitor : ExpressionVisitor
    {
        private bool _isNull;

        public NullVisitor()
        {
            _isNull = false;
        }

        public bool IsNull(Expression expression)
        {
            Visit(expression);
            return _isNull;
        }

        protected override Expression VisitConstant(ConstantExpression c)
        {
            _isNull = c.Value == null || string.Empty.Equals(c.Value);
            return c;
        }
    }
}
