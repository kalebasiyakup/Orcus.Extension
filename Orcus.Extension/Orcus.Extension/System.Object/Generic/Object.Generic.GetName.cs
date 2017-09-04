using System;
using System.Linq.Expressions;

public static partial class OrcusObjectExtension
{
    public static string GetName<TObject, TMember>(this TObject obj, Expression<Func<TObject, TMember>> expression)
    {
        expression.ThrowIfNull(nameof(expression));

        return GetName(expression.Body);
    }

    public static string GetName<TObject, TMember>(this TObject obj, Expression<Func<TMember>> expression)
    {
        expression.ThrowIfNull(nameof(expression));

        return GetName(expression.Body);
    }

    private static string GetName(Expression expression)
    {
        if (!expression.TryGetMemberExpression(out MemberExpression memberExpression))
            throw new ArgumentException("Geçerli bir expression bulunamadı.");

        return memberExpression.Member.Name;
    }
}
