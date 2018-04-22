using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringGetBeforeTest()
        {
            string str = "Orcus";

            string result1 = str.GetBefore("r");
            string result2 = str.GetBefore("a");

            Assert.AreEqual("O", result1);
            Assert.AreEqual("", result2);
        }
    }
}