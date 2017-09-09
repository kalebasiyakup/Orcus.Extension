using System;

public static partial class OrcusDateTimeExtension
{
    public static Int64 DateDiffHour(this DateTime StartDate, DateTime EndDate)
    {
        StartDate.ExceptionIfNull(nameof(StartDate));
        EndDate.ExceptionIfNull(nameof(EndDate));
        TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
        return (Int64)ts.TotalHours;
    }
}
