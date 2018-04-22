using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void EnumerableToDataTableTest()
        {
            IEnumerable<Product> thisNotEmpty = new List<Product>
            {
                new Product {CategoryID = 1, OutOfStock = false, ProductID = 2, ProductName = "TEST - 2", UnitPrice = 52},
                new Product {CategoryID = 2, OutOfStock = true, ProductID = 3, ProductName = "TEST - 3", UnitPrice = 53}
            }.AsEnumerable();

            var dt = thisNotEmpty.ToDataTable();
            Assert.IsTrue(dt.Rows.Count > 0);
        }
    }
}
