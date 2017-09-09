using System;

public static partial class OrcusDateTimeExtension
{
    public static Int64 DateDiffQuarter(this DateTime StartDate, DateTime EndDate)
    {
        StartDate.ExceptionIfNull(nameof(StartDate));
        EndDate.ExceptionIfNull(nameof(EndDate));
        System.Globalization.Calendar cal = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar;
        TimeSpan ts = new TimeSpan(EndDate.Ticks - StartDate.Ticks);
        return ((((cal.GetYear(EndDate)
                                    - cal.GetYear(StartDate)) * 4)
                                    + ((cal.GetMonth(EndDate) - 1) / 3))
                                    - ((cal.GetMonth(StartDate) - 1) / 3));
    }
}
