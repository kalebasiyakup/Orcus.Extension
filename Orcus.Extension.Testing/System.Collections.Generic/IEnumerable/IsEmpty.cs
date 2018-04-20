using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Orcus.Extension.Testing.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class IsEmpty
    {
        [TestMethod]
        public void IEnumerable_IsEmpty()
        {
            IEnumerable<string> thisEmpty = new List<string>().AsEnumerable();
            IEnumerable<string> thisNotEmpty = new List<string> { "Orcus" }.AsEnumerable();

            bool result2 = thisEmpty.IsEmpty(); // return true;
            bool result3 = thisNotEmpty.IsEmpty(); // return false;

            Assert.IsTrue(result2);
            Assert.IsFalse(result3);
        }
    }
}
