using System;

public static partial class OrcusStringExtension
{
    public static string[] Split(this string value,
        string separator,
        StringSplitOptions stringSplitOption = StringSplitOptions.None)
    {
        value.ExceptionIfNull(nameof(value));
        separator.ExceptionIfNull(nameof(separator));

        return value.Split(new[]
            {
                    separator
                },
            stringSplitOption);
    }

    public static string[] Split(this string value,
        StringSplitOptions stringSplitOption,
        params string[] separators)
    {
        value.ExceptionIfNull(nameof(value));
        separators.ExceptionIfNull(nameof(separators));

        return value.Split(separators, stringSplitOption);
    }
}
