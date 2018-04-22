using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringToMemoryStreamTest()
        {
            string str = "OrcusExtension";

            using (Stream value = str.ToMemoryStream())
            {
                Assert.IsNotNull(value);
            }
        }
    }
}