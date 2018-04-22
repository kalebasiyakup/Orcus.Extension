using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringIsAlphaNumericTest()
        {
            string thisAlphaNumeric = "abc123";
            string thisNotAlphaNumeric = "abc123!<>";

            bool value1 = thisAlphaNumeric.IsAlphaNumeric();
            bool value2 = thisNotAlphaNumeric.IsAlphaNumeric();

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}