using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static String ToShortDateString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("d", DateTimeFormatInfo.CurrentInfo);
    }

    public static String ToTrShortDateString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("d", new CultureInfo("tr-TR"));
    }

    public static String ToShortDateString(this DateTime dateTime, string culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("d", new CultureInfo(culture));
    }

    public static String ToShortDateString(this DateTime dateTime, CultureInfo culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("d", culture);
    }
}