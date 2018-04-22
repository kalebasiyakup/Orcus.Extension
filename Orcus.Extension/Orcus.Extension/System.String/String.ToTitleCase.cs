using System.Globalization;

public static partial class OrcusStringExtension
{
    public static string ToTitleCase(this string str)
    {
        return new CultureInfo("en-US").TextInfo.ToTitleCase(str);
    }

    public static string ToTitleCase(this string str, CultureInfo cultureInfo)
    {
        return cultureInfo.TextInfo.ToTitleCase(str);
    }
}
