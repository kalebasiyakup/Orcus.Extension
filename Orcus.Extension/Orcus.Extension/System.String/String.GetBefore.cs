public static partial class OrcusStringExtension
{
    public static string GetBefore(this string str, string value)
    {
        if (str.IndexOf(value) == -1)
        {
            return "";
        }
        return str.Substring(0, str.IndexOf(value));
    }
}
