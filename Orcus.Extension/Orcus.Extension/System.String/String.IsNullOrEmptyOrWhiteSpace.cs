public static partial class OrcusStringExtension
{
    public static bool IsNullOrEmptyOrWhiteSpace(this string str)
    {
        return string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str);
    }
}
