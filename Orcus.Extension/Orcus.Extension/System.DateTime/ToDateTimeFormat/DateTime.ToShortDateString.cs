using System;
using System.Globalization;

public static partial class OrcusDateTimeExtension
{
    public static String ToShortDateString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("d", DateTimeFormatInfo.CurrentInfo);
    }

    /// <summary>
    /// dd/MM/yyyy
    /// </summary>
    /// <param name="dateTime"></param>
    /// <returns>dd/MM/yyyy</returns>
    public static String ToTrShortDateString(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.ToString("dd/MM/yyyy", new CultureInfo("tr-TR"));
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