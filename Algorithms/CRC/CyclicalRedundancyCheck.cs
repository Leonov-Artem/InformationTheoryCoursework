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

        public string BinaryText { get; private set; }

        public int GeneratingPolynomDegree { get; private set; }

        public string GeneratingPolynom { get; private set; }

        public CyclicalRedundancyCheck()
        {

        }

        public CyclicalRedundancyCheck(string text, string polynom)
        {
            GeneratingPolynom = StringConverter.GeneratingPolynomToBinary(polynom);
            GeneratingPolynomDegree = GeneratingPolynom.Length - 1;
            BinaryText = StringConverter.HexToBinary(text);
            _bitString = AddZerosToEnd(BinaryText, GeneratingPolynomDegree);
        }

        public string CheckMessageIntegrity(string textWithCRC, string polynom)
        {
            _bitString = BinaryText = textWithCRC;
            GeneratingPolynom = polynom;
            GeneratingPolynomDegree = GeneratingPolynom.Length - 1;
            return Compute();
        }

        public string Compute()
        {
            while (_bitString.Length > GeneratingPolynomDegree)
            {
                BitStringXORgenPoly();
                RemoveExtraZerosFromBitStringStart();
            }

            return _bitString;
        }

        private void BitStringXORgenPoly()
        {
            string strToReplace = _bitString.Substring(0, GeneratingPolynom.Length);
            var xorResult = new StringBuilder();

            for (int i = 0; i < GeneratingPolynom.Length; i++)
            {
                if (_bitString[i] == GeneratingPolynom[i])
                    xorResult.Append('0');
                else
                    xorResult.Append('1');
            }

            _bitString = _bitString.Replace(strToReplace, xorResult.ToString());
        }

        private void RemoveExtraZerosFromBitStringStart()
        {
            while (_bitString.StartsWith("0"))
            {
                if (_bitString.Length > GeneratingPolynomDegree)
                    _bitString = _bitString.Remove(0, 1);
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
