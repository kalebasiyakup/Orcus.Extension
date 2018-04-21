using System;

public static partial class OrcusStringExtension
{
    public static string GetBefore(this string str, string value)
    {
        return str.IndexOf(value, StringComparison.Ordinal) == -1 ? "" : str.Substring(0, str.IndexOf(value, StringComparison.Ordinal));
    }
}
