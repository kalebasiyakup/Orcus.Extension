using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class SystemByteArray
    {
        [TestMethod]
        public void DecompressGZip()
        {
            byte[] @byte = "OrcusExtension".CompressGZip();

            string result = @byte.DecompressGZip();

            Assert.AreEqual("OrcusExtension", result);
        }
    }
}
