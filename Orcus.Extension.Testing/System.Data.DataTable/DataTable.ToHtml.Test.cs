using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void DataTableToHtmlTest()
        {
            var dt = DataSource.Products.ToDataTable();
            var html = dt.ToHtmlTable(true, true);

            Assert.IsNotNull(html);
        }
    }
}