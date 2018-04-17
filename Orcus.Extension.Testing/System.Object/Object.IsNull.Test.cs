using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class ObjectExtensionTest
    {
        [TestMethod]
        public void IsNullTest()
        {
            var value = (object)"objetest";
            var actual = value.IsNull();
            
            Assert.IsFalse(actual);

            value = null;
            actual = value.IsNull();

            Assert.IsTrue(actual);
        }
    }
}
