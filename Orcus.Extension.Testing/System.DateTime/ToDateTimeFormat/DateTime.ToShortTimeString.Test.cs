using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class DateTimeToShortTimeStringTest
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

            Assert.ThrowsException<ArgumentNullException>(null);
        }
    }
}
