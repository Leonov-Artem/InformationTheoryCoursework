using System.Linq;
using System.Collections.Generic;
using Algorithms.Huffman;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests
{
    [TestClass]
    public class HuffmanTests
    {
        [TestMethod]
        public void EncondeAndDecode_WithGivenFrequenciesTest()
        {
            string message = "aabbbc";
            var alphabetFreq = new Dictionary<char, int>()
            {
                ['a'] = 2,
                ['b'] = 3,
                ['c'] = 1
            };
            
            var huffmanTree = new HuffmanCode(alphabetFreq);

            string encode = huffmanTree.Encode(message);
            string decode = huffmanTree.Decode(encode);

            Assert.AreEqual("111100010", encode);
            Assert.AreEqual(message, decode);
        }

        [TestMethod]
        public void EncondeAndDecode_WithTextTest()
        {
            string text = "aabbbc";
            var huffmanTree = new HuffmanCode(text);

            string encode = huffmanTree.Encode(text);
            string decode = huffmanTree.Decode(encode);

            Assert.AreEqual("111100010", encode);
            Assert.AreEqual(text, decode);
        }

        [TestMethod]
        public void Coursework_Huffman_Test()
        {
            string text = "often this information is the individual identification";
            var a = text.Length;
            var huffmanTree = new HuffmanCode(text);

            var b = huffmanTree.CodeTable.OrderBy(x => x.Value.Length).ToList();
            string encode = huffmanTree.Encode(text);
            string decode = huffmanTree.Decode(encode);

            Assert.AreEqual(text, decode);
        }
    }
}
