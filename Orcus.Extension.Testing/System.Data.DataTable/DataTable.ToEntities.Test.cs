using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void DataTableToEntitiesTest()
        {
            var dt = DataSource.Products.ToDataTable();
            var entities = dt.ToEntities<Product>().ToList();
            // Unit Test
            Assert.AreEqual(12, entities.Count());
            Assert.AreEqual(1, entities[0].ProductID);
            Assert.AreEqual("Bath Rug, Soft", entities[0].ProductName);
            Assert.AreEqual(2, entities[1].ProductID);
            Assert.AreEqual("Shower Curtain", entities[1].ProductName);
        }
    }
}