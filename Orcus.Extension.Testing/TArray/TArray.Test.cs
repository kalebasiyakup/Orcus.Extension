using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
            [TestMethod]
            public void TArrayToDataTableTest()
            {
                // Type
                var itemsObjects = new[]
                {
                    new TestObject
                    {
                        Id = 11,
                        Name = "Ali"
                    },
                    new TestObject
                    {
                        Id = 33,
                        Name = "Veli"
                    }
                };

                DataTable dt = itemsObjects.ToDataTable();

                Assert.AreEqual(2, dt.Rows.Count);
                Assert.AreEqual(11, dt.Rows[0]["Id"]);
                Assert.AreEqual("Ali", dt.Rows[0]["Name"]);
                Assert.AreEqual(33, dt.Rows[1]["Id"]);
                Assert.AreEqual("Veli", dt.Rows[1]["Name"]);
            }

            public class TestObject
            {
                public int Id;
                public string Name { get; set; }
            }
    }
}