using System;

public static partial class OrcusDateTimeExtension
{
    public static bool IsWeekDay(this DateTime dateTime)
    {
        dateTime.ExceptionIfNull(nameof(dateTime));
        return !(dateTime.DayOfWeek == DayOfWeek.Saturday || dateTime.DayOfWeek == DayOfWeek.Sunday);
    }
}