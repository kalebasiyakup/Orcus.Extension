using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class SystemToBase64String
    {
        [TestMethod]
        public void ToBase64String()
        {
            byte[] @byte = "OrcusExtension".ToBytes();

            string result = @byte.ToBase64String();

            Assert.IsNotNull(result);
        }
    }
}
