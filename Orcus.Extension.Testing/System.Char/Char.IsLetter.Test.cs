using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void CharIsLetterTest()
        {
            const char isLetter = 'B';
            Assert.IsTrue(isLetter.IsLetter());
        }
    }
}