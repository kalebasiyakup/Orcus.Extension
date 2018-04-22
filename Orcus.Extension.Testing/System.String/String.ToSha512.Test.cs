using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringToSha512Test()
        {
            string result = "OrcusExtension";
            var sha512 = result.ToSha512();
            Assert.AreEqual("55A5FB2338C679CE352E1D8E2F82E42A2ED88B9F808A11B62C9F024AAD901B7C297A7D540A22F15971DC8032FF90D69F9CA6B9A805E78140A1C81BB4592717E7", sha512);
        }
    }
}