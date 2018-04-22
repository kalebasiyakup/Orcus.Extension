using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void CharIsNumberTest()
        {
            const char isNumeric = '8';
            Assert.IsTrue(isNumeric.IsNumber());
        }
    }
}