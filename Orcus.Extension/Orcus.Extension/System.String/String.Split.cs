using System;

public static partial class OrcusStringExtension
{
    public static string[] Split(this string value,
        string separator,
        StringSplitOptions stringSplitOption = StringSplitOptions.None)
    {
        value.ThrowIfNull(nameof(value));
        separator.ThrowIfNull(nameof(separator));

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
        value.ThrowIfNull(nameof(value));
        separators.ThrowIfNull(nameof(separators));

        return value.Split(separators, stringSplitOption);
    }
}
