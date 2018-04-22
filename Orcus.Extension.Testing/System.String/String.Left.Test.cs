using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringLeftTest()
        {
            string str = "Orcus";

            string value = str.Left(2); 

            Assert.AreEqual("Or", value);
        }
    }
}