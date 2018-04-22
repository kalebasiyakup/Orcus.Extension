using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringIsNotNullOrWhiteSpaceTest()
        {
            string thisNull = null;

            bool value1 = "  Orcus".IsNotNullOrWhiteSpace(); // return true;
            bool value2 = thisNull.IsNotNullOrWhiteSpace(); // return false;
            bool value3 = "".IsNotNullOrWhiteSpace(); // return false;
            bool value4 = "   ".IsNotNullOrWhiteSpace(); // return false;

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsFalse(value3);
            Assert.IsFalse(value4);
        }
    }
}