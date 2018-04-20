public static partial class OrcusStringExtension
{
    public static string Replace(this string str, int startIndex, int length, string value)
    {
        str = str.Remove(startIndex, length).Insert(startIndex, value);

        return str;
    }
}
