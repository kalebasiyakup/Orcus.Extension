using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class ObjectExtensionTest
    {
        [TestMethod]
        public void IsNullTest()
        {
            var value = (object)"objetest";
            var actual = value.IsNull();
            
            Assert.IsFalse(actual);

            value = null;
            actual = value.IsNull();

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void StringBinary()
        {
            var value = "objetest";
            var sb = value.SerializeBinary();
            Assert.IsNotNull(sb);

            var ds = sb.DeserializeBinary<string>();
            Assert.IsTrue(value == ds);
        }

        public class Sehirler
        {
            public List<Sehir> SehirListesi = new List<Sehir>();
            public Sehirler()
            {
            }

            public void ListAdd()
            {
                SehirListesi.Add(new Sehir() { Code = "IST", Name = "İstanbul" });
                SehirListesi.Add(new Sehir() { Code = "AYT", Name = "Antalya" });
                SehirListesi.Add(new Sehir() { Code = "ADB", Name = "İzmir" });
            }
        }

        public class Sehir
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }

        [TestMethod]
        public void StringJavaScript()
        {
            Sehirler sehirs = new Sehirler();
            sehirs.ListAdd();
            var js = sehirs.SerializeJavaScript();
            Assert.IsNotNull(js);

            var ds = js.DeserializeJavaScript<Sehirler>();
        }

        [TestMethod]
        public void StringXml()
        {
            Sehirler sehirs = new Sehirler();
            sehirs.ListAdd();
            var js = sehirs.SerializeXml();
            Assert.IsNotNull(js);

            var ds = js.DeserializeXml<Sehirler>();
        }

        [TestMethod]
        public void ObjectTo()
        {
            Sehirler sehirs = new Sehirler();
            sehirs.ListAdd();
            var obj  = (object)sehirs;
            var cls = obj.To<Sehirler>();
        }
    }
}
