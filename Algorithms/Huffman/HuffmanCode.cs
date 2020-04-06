using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Huffman
{
    public class HuffmanCode
    {
        const char LEFT_BIT_SYMBOL = '0';
        const char RIGHT_BIT_SYMBOL = '1';
        readonly int LEFT_NODE = 0;
        readonly int RIGHT_NODE = 1;

        string _text;

        public Dictionary<char, int> Frequencies { get; private set; }

        public Node HuffmanTree { get; private set; }

        public Dictionary<char, string> CodeTable { get; private set; }

        private HuffmanCode(string text, Dictionary<char, int> frequencies)
        {
            if (text != null)
            {
                _text = text;
                Frequencies = ComputeFrequencies(text);
                FieldsInitialize();
            }
            else if (frequencies != null)
            {
                Frequencies = frequencies;
                FieldsInitialize();
            }
        }

        public HuffmanCode(string text) 
            : this(text, null) { }

        public HuffmanCode(Dictionary<char, int> alphabetFrequencies)
            : this(null, alphabetFrequencies) { }

        public string Encode(string text)
        {
            var encode = new StringBuilder();
            foreach (var symbol in text)
                encode.Append(CodeTable[symbol]);

            return encode.ToString();
        }

        public string Encode()
        {
            if (_text != null)
                return Encode(_text);
            else
                throw new Exception("Текст не был задан!");
        }

        public string Decode(string huffmanCode)
        {
            Node currentNode = HuffmanTree;
            var decode = new StringBuilder();

            foreach (var bit in huffmanCode)
            {
                if (bit == LEFT_BIT_SYMBOL)
                    currentNode = currentNode.LeftChild;
                else if (bit == RIGHT_BIT_SYMBOL)
                    currentNode = currentNode.RightChild;
                else
                    throw new ArgumentException("Код Хаффмана должен содержать только 0 или 1.");

                if (currentNode.IsLeaf)
                {
                    decode.Append(currentNode.Symbol);
                    currentNode = HuffmanTree;
                }
            }

            return decode.ToString();
        }

        #region private methods

        private void FieldsInitialize()
        {
            HuffmanTree = BuildHuffmanTree(Frequencies);
            CodeTable = new Dictionary<char, string>();
            FillCodeTable(HuffmanTree);
        }

        private Dictionary<char, int> ComputeFrequencies(string text)
        {
            var alphabetFrequencies = new Dictionary<char, int>();
            foreach(var symbol in text)
            {
                if (alphabetFrequencies.ContainsKey(symbol))
                    alphabetFrequencies[symbol]++;
                else
                    alphabetFrequencies.Add(symbol, 1);
            }

            return alphabetFrequencies;
        }

        private Node BuildHuffmanTree(Dictionary<char, int> alphabetFrequencies)
        {
            List<Node> nodes = ToListNodes(alphabetFrequencies);

            while (nodes.Count > 1)
            {
                List<Node> taken = RemoveTwoMinNodes(nodes);
                Node parent = CreateParentNode(taken);
                nodes.Add(parent);
            }

            return nodes.FirstOrDefault();
        }

        private void FillCodeTable(Node currentNode, string bitString = "")
        {
            if (currentNode != null)
            {
                if (currentNode.IsLeaf)
                {
                    CodeTable[currentNode.Symbol] = bitString;
                    return;
                }

                FillCodeTable(currentNode.LeftChild, bitString + LEFT_BIT_SYMBOL);
                FillCodeTable(currentNode.RightChild, bitString + RIGHT_BIT_SYMBOL);
            }
        }

        private List<Node> ToListNodes(Dictionary<char, int> alphabetFrequencies)
        {
            var nodes = new List<Node>();
            foreach (var pair in alphabetFrequencies)
                nodes.Add(new Node(pair.Key, pair.Value));

            return nodes;
        }

        private List<Node> RemoveTwoMinNodes(List<Node> nodes)
        {
            List<Node> orderedNodes = SortAscending(nodes);
            List<Node> taken = orderedNodes.Take(2).ToList();
            nodes.Remove(taken[LEFT_NODE]);
            nodes.Remove(taken[RIGHT_NODE]);

            return taken;
        }

        private List<Node> SortAscending(List<Node> nodes)
            => nodes.OrderBy(node => node.Frequency).ToList<Node>();

        private Node CreateParentNode(List<Node> taken)
        {
            return new Node('*', taken[LEFT_NODE].Frequency + taken[RIGHT_NODE].Frequency)
            {
                LeftChild = taken[LEFT_NODE],
                RightChild = taken[RIGHT_NODE]
            };
        }

        #endregion
    }
}
