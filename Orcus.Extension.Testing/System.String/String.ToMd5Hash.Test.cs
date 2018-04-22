using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringToMd5HashTest()
        {
            string result = "OrcusExtension";
            var md5 = result.ToMd5Hash();
            // Unit Test
            Assert.AreEqual("e28c1c8807b542846e954b710f3af4ed", md5);
        }
    }
}