﻿namespace Algorithms.Huffman
{
    class Node
    {
        public double Frequency { get; set; }
        public char Symbol { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }

        public bool IsLeaf
        {
            get => LeftChild == null && RightChild == null;
        }

        public Node(char symbol, double frequency)
        {
            Frequency = frequency;
            Symbol = symbol;
        }
    }
}
