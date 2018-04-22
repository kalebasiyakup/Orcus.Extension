using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringReplaceTest()
        {
            string str = "OrcusExtension";

            string value = str.Replace(2, 3, "123456");

            Assert.AreEqual("Or123456Extension", value);
        }
    }
}