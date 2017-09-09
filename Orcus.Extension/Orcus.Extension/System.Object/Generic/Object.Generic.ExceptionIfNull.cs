using System;
using System.Linq.Expressions;

public static partial class OrcusObjectExtension
{
    public static void ExceptionIfNull<TObject>(this TObject obj,
        Expression<Func<TObject>> expression,
        string errorMessage = null)
    {
        if (obj != null)
            return;

        var parameterName = expression.GetName(expression);

        obj.ExceptionIfNull(parameterName, errorMessage);
    }

    public static void ExceptionIfNull<TObject>(this TObject obj,
        string parameterName,
        string errorMessage = null)
    {
        if (obj != null)
            return;

        throw new ArgumentNullException(parameterName,
            errorMessage ?? $"{parameterName} null olamaz.");
    }
}
