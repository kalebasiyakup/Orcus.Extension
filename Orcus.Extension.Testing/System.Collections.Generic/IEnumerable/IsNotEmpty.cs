using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace Orcus.Extension.Testing.System.Collections.Generic.IEnumerable
{
    [TestClass]
    public class IsNotEmpty
    {
        [TestMethod]
        public void IEnumerable_IsNotEmpty()
        {
            IEnumerable<string> thisEmpty = new List<string>().AsEnumerable();
            IEnumerable<string> thisNotEmpty = new List<string> { "Orcus" }.AsEnumerable();

            bool result2 = thisEmpty.IsNotEmpty(); // return false;
            bool result3 = thisNotEmpty.IsNotEmpty(); // return true;

            Assert.IsFalse(result2);
            Assert.IsTrue(result3);
        }
    }
}
