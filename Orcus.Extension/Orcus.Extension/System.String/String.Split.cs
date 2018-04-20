using System;

public static partial class OrcusStringExtension
{
    public static string[] Split(this string str,
        string separator,
        StringSplitOptions stringSplitOption = StringSplitOptions.None)
    {
        str.ExceptionIfNull(nameof(str));
        separator.ExceptionIfNull(nameof(separator));

        return str.Split(new[]
            {
                    separator
                },
            stringSplitOption);
    }

    public static string[] Split(this string str,
        StringSplitOptions stringSplitOption,
        params string[] separators)
    {
        str.ExceptionIfNull(nameof(str));
        separators.ExceptionIfNull(nameof(separators));

        return str.Split(separators, stringSplitOption);
    }
}
