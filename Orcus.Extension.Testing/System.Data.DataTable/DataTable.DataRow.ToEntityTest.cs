using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void DataTableDataRowToEntityTest()
        {
            var dataTable = new DataTable();

            dataTable.Columns.AddRange("ProductID", "ProductName");
            dataTable.Rows.Add(1, "Hello");

            var entity = dataTable.Rows[0].ToEntity<Product>();

            Assert.AreEqual(1, entity.ProductID);
            Assert.AreEqual("Hello", entity.ProductName);
        }
    }
}
