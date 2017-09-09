using System;

public static partial class OrcusDateTimeExtension
{
    public static bool IsToday(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return dateTime.Date == DateTime.Today;
    }
}