using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    public partial class OrcusExtensionTest
    {
        [TestMethod]
        public void StringSaveAsTest()
        {
            var fileInfo = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StringSaveAsTest.txt"));
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "StringSaveAsTest.txt");

            string str = "OrcusExtension";

            str.SaveAs(filePath);
            str.SaveAs(fileInfo);
            str.SaveAs(fileInfo, true);

            Assert.IsTrue(fileInfo.Exists);
            Assert.IsTrue(new FileInfo(filePath).Exists);
        }
    }
}