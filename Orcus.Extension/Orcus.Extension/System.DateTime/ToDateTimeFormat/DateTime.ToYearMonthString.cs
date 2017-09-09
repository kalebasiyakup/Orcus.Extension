using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static string ToYearMonthString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("y", DateTimeFormatInfo.CurrentInfo);
    }

    public static string ToTrYearMonthString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("y", new CultureInfo("tr-TR"));
    }

    public static string ToYearMonthString(this DateTime dateTime, string culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("y", new CultureInfo(culture));
    }

    public static string ToYearMonthString(this DateTime dateTime, CultureInfo culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("y", culture);
    }
}