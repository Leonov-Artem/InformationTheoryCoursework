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

        public int PolyDegree { get; private set; }

        public string GeneratingPoly { get; private set; }

        public CyclicalRedundancyCheck(string sourceMessage, string generatingPoly)
        {
            GeneratingPoly = generatingPoly;
            PolyDegree = generatingPoly.Length - 1;
            _bitString = AddZerosToEnd(sourceMessage, PolyDegree);
        }

        public string Compute()
        {
            while (_bitString.Length > PolyDegree)
            {
                _bitString = XOR(_bitString);
                RemoveExtraZerosFromStart(ref _bitString);
            }

            return _bitString;
        }

        private string XOR(string bitString)
        {
            string strToReplace = bitString.Substring(0, GeneratingPoly.Length);
            var xorResult = new StringBuilder();

            for (int i = 0; i < GeneratingPoly.Length; i++)
            {
                if (bitString[i] == GeneratingPoly[i])
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
                if (bitString.Length > PolyDegree)
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

        private string HexToBinary(string sourceMessage)
        {
            throw new NotImplementedException();
        }

        private string GenPolyToBinary(string generatingPoly)
        {
            throw new NotImplementedException();
        }
    }
}
