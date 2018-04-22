using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringRightTest()
        {
            string str = "Orcus";

            string value = str.Right(2);

            Assert.AreEqual("us", value);
        }
    }
}