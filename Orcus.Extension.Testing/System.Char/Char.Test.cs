using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orcus.Extension.Testing
{
    [TestClass]
    public class Char
    {
        [TestMethod]
        public void CharTest()
        {
            char isDigit = '5';
            Assert.IsTrue(isDigit.IsDigit());

            char isLetter = 'B';
            Assert.IsTrue(isLetter.IsLetter());

            char isNumeric = '8';
            Assert.IsTrue(isNumeric.IsNumber());

            char isPunctuation = '(';
            Assert.IsTrue(isPunctuation.IsPunctuation());

            char isSymbol = '<';
            Assert.IsTrue(isSymbol.IsSymbol());
        }
    }
}
