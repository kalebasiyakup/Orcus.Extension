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
            IEnumerable<string> thisNotEmpty = new List<string> { "Orcus" }.AsEnumerable();

            bool result3 = thisNotEmpty.IsNotEmpty(); // return true;

            Assert.IsTrue(result3);
        }
    }
}
