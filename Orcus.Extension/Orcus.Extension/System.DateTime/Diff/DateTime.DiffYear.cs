using System;

public static partial class OrcusDateTimeExtension
{
    public static long DateDiffYear(this DateTime startDate, DateTime endDate)
    {
        startDate.ExceptionIfNull(nameof(startDate));
        endDate.ExceptionIfNull(nameof(endDate));
        var cal = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;
        return cal.GetYear(endDate) - cal.GetYear(startDate);
    }
}
