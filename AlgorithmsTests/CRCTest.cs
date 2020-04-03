using Algorithms.CRC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests
{
    [TestClass]
    public class CRCTest
    {
        [TestMethod]
        public void ComputeTest()
        {
            string text = "1101011011";
            string polynom = "10011";

            var CRC = new CyclicalRedundancyCheck(text, polynom);
            Assert.AreEqual("1110", CRC.Compute());
        }

        [TestMethod]
        public void ComputeTest2()
        {
            string text = "10001001010101101001111001001010";
            string polynom = "110001101";

            var CRC = new CyclicalRedundancyCheck(text, polynom);
            Assert.AreEqual("01000010", CRC.Compute());
        }
    }
}
