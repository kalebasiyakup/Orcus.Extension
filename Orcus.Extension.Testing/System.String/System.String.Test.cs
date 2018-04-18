using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringTest()
        {
            string value = "YAKUPŞİĞÜÖÇKALEBAŞI";
            var result = value.CleanTurkishCharacter();
            var left = value.Left(3);
            var right = value.Right(3);

            string spl = "YAKUP,KALEBAŞI,ALİ,VELİ";
            var split = spl.Split(',');

            var isNumeric = spl.IsNumeric();
            var isnullemptywc = spl.IsNullOrEmptyOrWhiteSpace();
            var isAplha = "C".IsAlpha();
            var sha = value.ToSha512();
            var md5 = value.ToMd5Hash();

            var cs = "Hello world!".CompressStringToBase64();
            var ds = cs.DecompressStringFromBase64();
        }
    }
}
