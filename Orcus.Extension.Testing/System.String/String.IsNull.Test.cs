using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringIsNullTest()
        {
            string thisNull = null;

            bool value1 = thisNull.IsNullOrEmpty();

            Assert.IsTrue(value1);
        }
    }
}