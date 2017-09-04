public static partial class OrcusStringExtension
{
    public static bool IsNullOrEmptyOrWhiteSpace(this string value)
    {
        return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
    }
}
