﻿using System;
using System.Collections.Generic;
using Algorithms.Huffman;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgorithmsTests
{
    [TestClass]
    public class HuffmanTreeTests
    {
        [TestMethod]
        public void EncondeAndDecode_WithGivenFrequenciesTest()
        {
            string message = "aabbbc";
            var alphabetFreq = new Dictionary<char, double>()
            {
                ['a'] = 2,
                ['b'] = 3,
                ['c'] = 1
            };
            
            var huffmanTree = new HuffmanCodes(alphabetFreq);

            string encode = huffmanTree.Encode(message);
            string decode = huffmanTree.Decode(encode);

            Assert.AreEqual("111100010", encode);
            Assert.AreEqual(message, decode);
        }

        [TestMethod]
        public void EncondeAndDecode_WithTextTest()
        {
            string text = "aabbbc";
            var huffmanTree = new HuffmanCodes(text);

            string encode = huffmanTree.Encode(text);
            string decode = huffmanTree.Decode(encode);

            Assert.AreEqual("111100010", encode);
            Assert.AreEqual(text, decode);
        }
    }
}
