using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class IListExtensionTest
    {
        [TestMethod]
        public void ToCsv()
        {
            DataSource.Products.ToCsv<Product>(exclude: "ProductId,OutOfStock");
            
            Assert.IsTrue(true);
        }
    }
}
