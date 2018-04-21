using System;

public static partial class OrcusStringExtension
{
    public static string GetAfter(this string str, string value)
    {
        return str.IndexOf(value, StringComparison.Ordinal) == -1 ? "" : str.Substring(str.IndexOf(value, StringComparison.Ordinal) + value.Length);
    }
}
