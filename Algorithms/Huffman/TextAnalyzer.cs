using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms.Huffman
{
    public class TextAnalyzer
    {
        string _text;
        HuffmanCode _huffmanCode;
        Node _huffmanTree;
        Dictionary<char, double> _probabilities;
        Dictionary<char, int> _depths;

        public char[] Alphabet { get; }

        public TextAnalyzer(string text)
        {
            _text = text;
            _huffmanCode = new HuffmanCode(text);
            Alphabet = _huffmanCode.CodeTable.Keys.ToArray();
            _probabilities = ToProbabilities(_huffmanCode.Frequencies);
            _huffmanTree = _huffmanCode.HuffmanTree;
            _depths = new Dictionary<char, int>();
            ComputeTreeSymbolsDepth(_huffmanTree);
        }

        public double ShannonEntropy()
        {
            double entropy = 0;
            foreach (var probability in _probabilities.Values)
                entropy += Shannon(probability);

            return -entropy;
        }

        public double AverageCodingMessageLength()
        {
            double sum = 0;
            foreach (var symbol in Alphabet)
                sum += _depths[symbol] * _probabilities[symbol];

            return sum;
        }

        private Dictionary<char, double> ToProbabilities(Dictionary<char, int> frequencies)
        {
            var probabilities = new Dictionary<char, double>();
            foreach (var pair in frequencies)
                probabilities[pair.Key] = (double)pair.Value / _text.Length;

            return probabilities;
        }

        private double Shannon(double probability)
            => probability * Math.Log(probability, 2);

        private void ComputeTreeSymbolsDepth(Node currentNode, int depth=0)
        {
            if (currentNode != null)
            {
                if (currentNode.IsLeaf)
                {
                    _depths[currentNode.Symbol] = depth;
                    return;
                }

                ComputeTreeSymbolsDepth(currentNode.LeftChild, depth + 1);
                ComputeTreeSymbolsDepth(currentNode.RightChild, depth + 1);
            }
        }
    }
}
