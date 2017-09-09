using System;

public static partial class OrcusDateTimeExtension
{
    public static long DateDiffMinute(this DateTime startDate, DateTime endDate)
    {
        startDate.ExceptionIfNull(nameof(startDate));
        endDate.ExceptionIfNull(nameof(endDate));
        var ts = new TimeSpan(endDate.Ticks - startDate.Ticks);
        return (long)ts.TotalMinutes;
    }
}
