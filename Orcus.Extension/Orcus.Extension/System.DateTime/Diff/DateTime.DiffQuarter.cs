using System;

public static partial class OrcusDateTimeExtension
{
    public static long DateDiffQuarter(this DateTime startDate, DateTime endDate)
    {
        startDate.ExceptionIfNull(nameof(startDate));
        endDate.ExceptionIfNull(nameof(endDate));
        var cal = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;
        return (cal.GetYear(endDate) - cal.GetYear(startDate)) * 4 + (cal.GetMonth(endDate) - 1) / 3 - (cal.GetMonth(startDate) - 1) / 3;
    }
}
