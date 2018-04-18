using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class DateTimeTest
    {
        [TestMethod]
        public void ToShortTimeStringTest()
        {
            var v = DateTime.Now.ToTrFullDateShortTimeString();
            var v1 = DateTime.Now.ToTrFullDateTimeString();
            var v2 = DateTime.Now.ToTrLongDateString();
            var v3 = DateTime.Now.ToTrLongTimeString();
            var v4 = DateTime.Now.ToTrMonthDayString();
            var v5 = DateTime.Now.ToTrShortDateString();
            var v6 = DateTime.Now.ToTrShortDateTimeString();
            var v7 = DateTime.Now.ToTrShortTimeString();
            var v8 = DateTime.Now.ToTrYearMonthString();
        }

        [TestMethod]
        public void IsToday()
        {
            Assert.IsTrue(DateTime.Now.IsToday());
        }

        [TestMethod]
        public void IsWeekDay()
        {
            Assert.IsTrue(new DateTime(2018,04,18).IsWeekDay());
        }

        [TestMethod]
        public void IsWeekendDay()
        {
            Assert.IsTrue(new DateTime(2018, 04, 22).IsWeekendDay());
        }

        [TestMethod]
        public void DatetimeDiff()
        {
            var v = DateTime.Now.DateDiffDay(DateTime.Now.AddDays(2));
            var v1 = DateTime.Now.DateDiffHour(DateTime.Now.AddHours(2));
            var v2 = DateTime.Now.DateDiffMiliSecond(DateTime.Now.AddMilliseconds(20));
            var v3 = DateTime.Now.DateDiffMinute(DateTime.Now.AddMinutes(20));
            var v4 = DateTime.Now.DateDiffMonth(DateTime.Now.AddMonths(2));
            var v5 = DateTime.Now.DateDiffSeconds(DateTime.Now.AddSeconds(20));
            var v6 = DateTime.Now.DateDiffWeek(DateTime.Now.AddMonths(1));
            var v7 = DateTime.Now.DateDiffYear(DateTime.Now.AddYears(2));
        }
    }
}
