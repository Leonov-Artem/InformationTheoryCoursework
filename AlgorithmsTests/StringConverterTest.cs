using Algorithms.CRC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests
{
    [TestClass]
    public class StringConverterTest
    {
        [TestMethod]
        public void HexToBinaryTest()
        {
            string hexNum = "89 56 9E 4A";
            string binaryNum = StringConverter.HexToBinary(hexNum);
            Assert.AreEqual("10001001010101101001111001001010", binaryNum);
        }

        [TestMethod]
        public void GenPolyToBinatyTest()
        {
            var b = string.Join("", new int[] { 1, 2, 4 });
            string polynom = "x^8 + x^7 + x^3 + x^2 + 1";
            string binary = StringConverter.GeneratingPolynomToBinary(polynom);
            Assert.AreEqual("110001101", binary);
        }
    }
}
