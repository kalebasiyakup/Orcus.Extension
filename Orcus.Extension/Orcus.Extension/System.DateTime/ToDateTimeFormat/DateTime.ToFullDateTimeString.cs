using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static String ToFullDateTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("F", DateTimeFormatInfo.CurrentInfo);
    }

    public static String ToTrFullDateTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("F", new CultureInfo("tr-TR"));
    }

    public static String ToFullDateTimeString(this DateTime dateTime, string culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("F", new CultureInfo(culture));
    }

    public static String ToFullDateTimeString(this DateTime dateTime, CultureInfo culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("F", culture);
    }
}