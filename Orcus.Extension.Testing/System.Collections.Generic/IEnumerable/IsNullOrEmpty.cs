using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Orcus.Extension.Testing.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class IsNullOrEmpty
    {
        [TestMethod]
        public void IEnumerable_IsNullOrEmpty()
        {
            List<string> thisNull = null;
            IEnumerable<string> thisEmpty = new List<string>().AsEnumerable();
            IEnumerable<string> thisNotEmpty = new List<string> { "Orcus" }.AsEnumerable();

            bool result1 = thisNull.IsNullOrEmpty(); // return true;
            bool result2 = thisEmpty.IsNullOrEmpty(); // return true;
            bool result3 = thisNotEmpty.IsNullOrEmpty(); // return false;

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
        }
    }
}
