using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void ListToCsvTest()
        {
            DataSource.Products.ToCsv<Product>(exclude: "ProductId,OutOfStock");

            Assert.IsTrue(true);
        }
    }
}
