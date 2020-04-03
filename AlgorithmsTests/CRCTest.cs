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
            string text = "89 56 9E 4A";
            string polynom = "x^8 + x^7 + x^3 + x^2 + 1";

            var CRC = new CyclicalRedundancyCheck(text, polynom);
            Assert.AreEqual("01000010", CRC.Compute());
        }
    }
}
