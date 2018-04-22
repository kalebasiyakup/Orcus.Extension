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

            bool result2 = thisEmpty.IsEmpty(); // return true;

            Assert.IsTrue(result2);
        }
    }
}