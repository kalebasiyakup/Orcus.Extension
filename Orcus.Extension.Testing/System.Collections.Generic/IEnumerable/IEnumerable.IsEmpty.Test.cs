using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void EnumerableIsEmptyTest()
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