public static partial class OrcusStringExtension
{
    public static string GetAfter(this string str, string value)
    {
        if (str.IndexOf(value) == -1)
        {
            return "";
        }
        return str.Substring(str.IndexOf(value) + value.Length);
    }
}
