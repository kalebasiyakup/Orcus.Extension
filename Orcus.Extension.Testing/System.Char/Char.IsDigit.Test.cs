using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void CharIsDigitTest()
        {
            const char isDigit = '5';
            Assert.IsTrue(isDigit.IsDigit());
        }
    }
}