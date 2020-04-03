using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CRC
{
    public class CyclicalRedundancyCheck
    {
        string _bitString;

        public int GeneratingPolynomDegree { get; private set; }

        public string GeneratingPolynom { get; private set; }

        public CyclicalRedundancyCheck(string text, string polynom)
        {
            GeneratingPolynom = StringConverter.GeneratingPolynomToBinary(polynom);
            GeneratingPolynomDegree = GeneratingPolynom.Length - 1;
            string binary = StringConverter.HexToBinary(text);
            _bitString = AddZerosToEnd(binary, GeneratingPolynomDegree);
        }

        public string Compute()
        {
            while (_bitString.Length > GeneratingPolynomDegree)
            {
                _bitString = XOR(_bitString);
                RemoveExtraZerosFromStart(ref _bitString);
            }

            return _bitString;
        }

        private string XOR(string bitString)
        {
            string strToReplace = bitString.Substring(0, GeneratingPolynom.Length);
            var xorResult = new StringBuilder();

            for (int i = 0; i < GeneratingPolynom.Length; i++)
            {
                if (bitString[i] == GeneratingPolynom[i])
                    xorResult.Append('0');
                else
                    xorResult.Append('1');
            }

            return bitString.Replace(strToReplace, xorResult.ToString());
        }

        private void RemoveExtraZerosFromStart(ref string bitString)
        {
            while (bitString.StartsWith("0"))
            {
                if (bitString.Length > GeneratingPolynomDegree)
                    bitString = bitString.Remove(0, 1);
                else
                    return;
            }
        }

        private string AddZerosToEnd(string sourceMessage, int count)
        {
            var newBitStr = new StringBuilder(sourceMessage);
            for (int i = 0; i < count; i++)
                newBitStr.Append("0");

            return newBitStr.ToString();
        }
    }
}
