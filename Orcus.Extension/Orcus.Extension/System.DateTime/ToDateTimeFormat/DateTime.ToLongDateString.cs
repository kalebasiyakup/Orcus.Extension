using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static String ToLongDateString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("D", DateTimeFormatInfo.CurrentInfo);
    }

    public static String ToTrLongDateString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("D", new CultureInfo("tr-TR"));
    }

    public static String ToLongDateString(this DateTime dateTime, string culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("D", new CultureInfo(culture));
    }

    public static String ToLongDateString(this DateTime dateTime, CultureInfo culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("D", culture);
    }
}