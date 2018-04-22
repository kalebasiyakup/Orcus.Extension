using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringIsNotNullTest()
        {
            string thisValue = "Orcus";
            string thisNull = null;

            bool value1 = thisValue.IsNullOrEmpty();
            bool value2 = thisNull.IsNullOrEmpty();

            Assert.IsFalse(value1);
            Assert.IsTrue(value2);
        }
    }
}