using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static String ToShortDateTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("g", DateTimeFormatInfo.CurrentInfo);
    }

    /// <summary>
    /// dd/MM/yyyy HH:mm
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns>dd/MM/yyyy HH:mm</returns>
    public static String ToTrShortDateTimeString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("dd/MM/yyyy HH:mm", new CultureInfo("tr-TR"));
    }

    public static String ToShortDateTimeString(this DateTime dateTime, string culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("g", new CultureInfo(culture));
    }

    public static String ToShortDateTimeString(this DateTime dateTime, CultureInfo culture)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("g", culture);
    }
}