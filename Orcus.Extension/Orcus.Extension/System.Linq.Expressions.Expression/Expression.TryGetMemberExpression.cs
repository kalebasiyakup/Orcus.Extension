using System.Linq.Expressions;

public static class OrcusExpressionExtension
{
    public static bool TryGetMemberExpression(this Expression expression, out MemberExpression memberExpression)
    {
        expression.ExceptionIfNull(nameof(expression));

        while (true)
            switch (expression.NodeType)
            {
                case ExpressionType.MemberAccess:
                    memberExpression = expression as MemberExpression;
                    return true;

                case ExpressionType.Convert:
                    var operand = (expression as UnaryExpression).Operand;
                    if (operand is MemberExpression)
                    {
                        memberExpression = operand as MemberExpression;
                        return true;
                    }

                    memberExpression = null;
                    return false;

                case ExpressionType.Constant:
                    memberExpression = null;
                    return false;

                case ExpressionType.Lambda:
                    expression = ((LambdaExpression)expression).Body;
                    break;

                default:
                    memberExpression = null;
                    return false;
            }
    }
}
