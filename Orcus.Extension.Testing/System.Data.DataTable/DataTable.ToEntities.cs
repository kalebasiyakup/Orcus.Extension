using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class System_Data_DataTable_ToEntities
    {
        [TestMethod]
        public void ToEntities()
        {
            var dt = new DataTable();

            dt.Columns.Add(new DataColumn ("IntColumn"));
            dt.Columns.Add(new DataColumn ("StringColumn"));
            dt.Rows.Add(1, "Ali");
            dt.Rows.Add(2, "Veli");

            List<TestObject> entities = dt.ToEntities<TestObject>().ToList();

            Assert.AreEqual(2, entities.Count);
            Assert.AreEqual(1, entities[0].IntColumn);
            Assert.AreEqual("Ali", entities[0].StringColumn);
            Assert.AreEqual(2, entities[1].IntColumn);
            Assert.AreEqual("Veli", entities[1].StringColumn);
        }

        public class TestObject
        {
            public int IntColumn;
            public string StringColumn { get; set; }
        }
    }
}
