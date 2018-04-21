using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void IOFileInfoTest()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Windows\WindowsUpdate.log");
            var result = fileInfo.ReadToEnd();
            Assert.IsNotNull(result);
        }
    }
}
