using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.CRC
{
    public static class StringConverter
    {
        const string DEGREE_SEARCH_PATTERN = @"\^(\d+)";

        public static string HexToBinary(string sourceMessage)
        {
            string[] hexNums = sourceMessage.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string hexNum = string.Join("", hexNums);
            int intNum = Convert.ToInt32(hexNum, 16);

            return Convert.ToString(intNum, 2);
        }

        public static string GeneratingPolynomToBinary(string polynom)
        {
            List<int> degrees = FindAllPolynomDegree(polynom);
            int maxDegree = degrees.Max();
            var array = new int[maxDegree + 1];

            foreach (int degree in degrees)
                array[degree] = 1;
            Array.Reverse(array);

            return string.Join("", array);
        }

        private static List<int> FindAllPolynomDegree(string polynom)
        {
            var list = new List<int>();
            var regex = new Regex(DEGREE_SEARCH_PATTERN);

            int degree;
            foreach (Match match in regex.Matches(polynom))
            {
                degree = int.Parse(match.Groups[1].Value);
                list.Add(degree);
            }
            list.Add(0);

            return list;
        }
    }
}
