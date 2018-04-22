using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringGetBetweenTest()
        {
            string str = "Orcus";

            string result1 = str.GetBetween("O", "c");
            string result2 = str.GetBetween("a", "b");

            Assert.AreEqual("r", result1);
            Assert.AreEqual("", result2);
        }
    }
}