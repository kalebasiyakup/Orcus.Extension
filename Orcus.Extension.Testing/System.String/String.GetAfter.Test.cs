using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringGetAfterTest()
        {
            string str = "Orcus";

            string result1 = str.GetAfter("c");
            string result2 = str.GetAfter("a");

            Assert.AreEqual("us", result1);
            Assert.AreEqual("", result2);
        }
    }
}