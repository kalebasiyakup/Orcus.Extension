using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static String ToLongTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("T", DateTimeFormatInfo.CurrentInfo);
    }

    public static String ToTrLongTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("T", new CultureInfo("tr-TR"));
    }

    public static String ToLongTimeString(this DateTime dateTime, string culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("T", new CultureInfo(culture));
    }

    public static String ToLongTimeString(this DateTime dateTime, CultureInfo culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("T", culture);
    }
}