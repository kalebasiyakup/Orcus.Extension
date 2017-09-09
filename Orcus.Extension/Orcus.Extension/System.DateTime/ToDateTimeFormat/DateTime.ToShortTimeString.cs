using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static String ToShortTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("t", DateTimeFormatInfo.CurrentInfo);
    }

    public static String ToTrShortTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("t", new CultureInfo("tr-TR"));
    }

    public static String ToShortTimeString(this DateTime dateTime, string culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("t", new CultureInfo(culture));
    }

    public static String ToShortTimeString(this DateTime dateTime, CultureInfo culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("t", culture);
    }
}