using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static String ToFullDateShortTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("f", DateTimeFormatInfo.CurrentInfo);
    }

    public static String ToTrFullDateShortTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("f", new CultureInfo("tr-TR"));
    }

    public static String ToFullDateShortTimeString(this DateTime dateTime, string culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("f", new CultureInfo(culture));
    }

    public static String ToFullDateShortTimeString(this DateTime dateTime, CultureInfo culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("f", culture);
    }
}