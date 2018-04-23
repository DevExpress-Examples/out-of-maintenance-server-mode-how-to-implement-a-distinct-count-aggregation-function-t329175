using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.PivotGrid.ServerMode.Queryable;
using System.Linq.Expressions;
using DevExpress.Data.Linq;

namespace XPG_ServerMode_EF
{
    class DistinctCountFunction : ICustomFunctionOperator, ICustomFunctionOperatorFormattable, IQueryableConvertible
    {
        internal const string Name = "DistinctCount";

        public DistinctCountFunction() { }

        object ICustomFunctionOperator.Evaluate(params object[] operands)
        {
            return -1;
        }

        string ICustomFunctionOperator.Name
        {
            get { return Name; }
        }

        Type ICustomFunctionOperator.ResultType(params Type[] operands)
        {
            return typeof(int);
        }

        string ICustomFunctionOperatorFormattable.Format(Type providerType, params string[] operands)
        {
            return string.Format("Count(distinct {0})", operands[0]);
        }       
        
        #region IQueryableConvertible Members
        Type GetElementType(Expression thisExpression) {
            return thisExpression.Type.GetInterfaces().First((type) => type.IsGenericType && type.Name == "IEnumerable`1").GetGenericArguments()[0];
        }

        System.Linq.Expressions.Expression IQueryableConvertible.Convert(CriteriaOperatorCollection operands, Expression thisExpression, ICriteriaToExpressionConverter converter) {
            Type elementType = GetElementType(thisExpression);
            ParameterExpression elementParameter = Expression.Parameter(elementType, "elem");
            LambdaExpression groupSelect = Expression.Lambda(converter.Convert(elementParameter, operands[1]), elementParameter);
            Expression groupEpression = Expression.Call(typeof(Enumerable), "GroupBy", new Type[] { elementType, groupSelect.Body.Type }, thisExpression, groupSelect);
            return Expression.Call(typeof(Enumerable), "Count", new Type[] { groupEpression.Type.GetGenericArguments()[0] }, groupEpression);
        }
       

        public QueryableKind QueryableKind {
            get { return DevExpress.PivotGrid.ServerMode.Queryable.QueryableKind.Aggregate; }
        }

        #endregion
    }
}
