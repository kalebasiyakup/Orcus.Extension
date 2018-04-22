using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void CharIsSymbolTest()
        {
            const char isSymbol = '<';
            Assert.IsTrue(isSymbol.IsSymbol());
        }
    }
}