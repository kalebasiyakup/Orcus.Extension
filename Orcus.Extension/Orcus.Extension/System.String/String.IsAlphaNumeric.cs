using System.Text.RegularExpressions;

public static partial class OrcusStringExtension
{
    public static bool IsAlphaNumeric(this string str)
    {
        return !Regex.IsMatch(str, "[^a-zA-Z0-9]");
    }
}
