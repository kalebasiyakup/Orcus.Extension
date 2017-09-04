using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LeftArgumentNullExceptionTest()
        {
            string value = null;
            Action test = () => value.Left(1);

            Assert.ThrowsException<ArgumentNullException>(test);
        }
    }
}
