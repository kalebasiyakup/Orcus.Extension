using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class IO
    {
        [TestMethod]
        public void IOTest()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Windows\WindowsUpdate.log");
            var result = fileInfo.ReadToEnd();
            Assert.IsNotNull(result);
        }
    }
}
