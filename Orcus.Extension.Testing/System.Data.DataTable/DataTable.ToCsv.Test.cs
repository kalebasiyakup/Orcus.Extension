using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void DataTableToCsvTest()
        {
            var dt = DataSource.Products.ToDataTable();
            dt.ToCsv();

            Assert.IsTrue(true);
        }
    }
}