using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringToTitleCaseTest()
        {
            string str = "orcus extension";

            string result = str.ToTitleCase();

            Assert.AreEqual("Orcus Extension", result);
        }
    }
}
