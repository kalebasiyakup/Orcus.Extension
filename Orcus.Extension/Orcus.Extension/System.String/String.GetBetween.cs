using System;

public static partial class OrcusStringExtension
{
    public static string GetBetween(this string str, string before, string after)
    {
        int beforeStartIndex = str.IndexOf(before, StringComparison.Ordinal);
        int startIndex = beforeStartIndex + before.Length;
        int afterStartIndex = str.IndexOf(after, startIndex, StringComparison.Ordinal);

        if (beforeStartIndex == -1 || afterStartIndex == -1)
        {
            return "";
        }

        return str.Substring(startIndex, afterStartIndex - startIndex);
    }
}
