using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void EnumerableIsNotEmptyTest()
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
