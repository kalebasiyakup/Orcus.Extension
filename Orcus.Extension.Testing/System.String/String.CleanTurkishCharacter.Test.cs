using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringCleanTurkishCharacterTest()
        {
            string trStr = "Ş";
            Assert.AreEqual("S", trStr.CleanTurkishCharacter());
        }
    }
}
