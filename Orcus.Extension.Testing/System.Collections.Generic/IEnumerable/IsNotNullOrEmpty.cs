using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Orcus.Extension.Testing.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class IsNotNullOrEmpty
    {
        [TestMethod]
        public void IEnumerable_IsNotNullOrEmpty()
        {
            List<string> thisNull = null;
            IEnumerable<string> thisEmpty = new List<string>().AsEnumerable();
            IEnumerable<string> thisNotEmpty = new List<string> { "Orcus" }.AsEnumerable();

            bool result1 = thisNull.IsNotNullOrEmpty(); // return false;
            bool result2 = thisEmpty.IsNotNullOrEmpty(); // return false;
            bool result3 = thisNotEmpty.IsNotNullOrEmpty(); // return true;

            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }
    }
}
