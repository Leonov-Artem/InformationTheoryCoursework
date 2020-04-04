using Algorithms.CRC;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests
{
    [TestClass]
    public class CRCTest
    {
        string text = "89 56 9E 4A";
        string polynom = "x^8 + x^7 + x^3 + x^2 + 1";
        CyclicalRedundancyCheck CRC;

        [TestInitialize]
        public void Initialize()
        {
            CRC = new CyclicalRedundancyCheck(text, polynom);
        }

        [TestMethod]
        public void ComputeCRC_Test()
        {
            Assert.AreEqual("01000010", CRC.Compute());
        }

        [TestMethod]
        public void CheckIntegrity_WithZeroRemainderTest()
        {
            string textWithCRC = CRC.BinaryText + CRC.Compute();
            var dataIntegrity = new CyclicalRedundancyCheck();
            string remainder = dataIntegrity.CheckMessageIntegrity(textWithCRC, CRC.GeneratingPolynom);

            Assert.IsFalse(remainder.Contains("1"));
        }

        [TestMethod]
        public void CheckIntegrity_WithNonZeroRemainderTest()
        {
            string textWithCRC = "1" + CRC.BinaryText + "1" + CRC.Compute();
            var dataIntegrity = new CyclicalRedundancyCheck();
            string remainder = dataIntegrity.CheckMessageIntegrity(textWithCRC, CRC.GeneratingPolynom);

            Assert.IsTrue(remainder.Contains("1"));
        }
    }
}
