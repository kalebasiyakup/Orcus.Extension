using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static string ToMonthDayString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("m", DateTimeFormatInfo.CurrentInfo);
    }

    public static string ToTrMonthDayString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("m", new CultureInfo("tr-TR"));
    }

    public static string ToMonthDayString(this DateTime dateTime, string culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("m", new CultureInfo(culture));
    }

    public static string ToMonthDayString(this DateTime dateTime, CultureInfo culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("m", culture);
    }
}