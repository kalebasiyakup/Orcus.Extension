using System;

public static partial class OrcusDateTimeExtension
{
    public static long DateDiffMonth(this DateTime startDate, DateTime endDate)
    {
        startDate.ExceptionIfNull(nameof(startDate));
        endDate.ExceptionIfNull(nameof(endDate));
        var cal = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;
        return (cal.GetYear(endDate) - cal.GetYear(startDate)) * 12 + cal.GetMonth(endDate) - cal.GetMonth(startDate);
    }
}
