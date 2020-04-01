using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithms.Huffman;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests
{
    [TestClass]
    public class TextAnalyzerTest
    {
        [TestMethod]
        public void CalculateEntropyTest()
        {
            string text = "often this information is the individual identification";
            var analyzer = new TextAnalyzer(text);

            double entropy = analyzer.ShannonEntropy();
            Assert.AreEqual(3.68, Math.Round(entropy, 2));
        }

        [TestMethod]
        public void AverageCodingMessageLengthTest()
        {
            string text = "often this information is the individual identification";
            var analyzer = new TextAnalyzer(text);

            double averageLength = analyzer.AverageCodingMessageLength();
            Assert.AreEqual(3.73, Math.Round(averageLength, 2));
        }
    }
}
