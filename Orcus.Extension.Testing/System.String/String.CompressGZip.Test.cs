using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringCompressGZipTest()
        {
            byte[] val = "OrcusExtension".CompressGZip();

            string result = val.DecompressGZip();

            Assert.AreEqual("OrcusExtension", result);
        }
    }
}