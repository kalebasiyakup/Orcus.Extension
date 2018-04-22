using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringIsNumericTest()
        {
            string thisNumeric = "987";
            string thisNotNumeric = "hhj876";

            bool value1 = thisNumeric.IsNumeric(); // return true;
            bool value2 = thisNotNumeric.IsNumeric(); // return false;

            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}