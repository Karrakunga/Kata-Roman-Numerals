using System;
using System.Collections.Generic;

namespace Kata_Roman_Numerals
{

    public class RomanNumeralConverter
    {
        private readonly Dictionary<string, int> _roman2Decimal = new Dictionary<string, int>
            {
                   {"I", 1},
                   {"II", 2},
                   {"III", 3},
                   {"IV", 4},
                   {"V", 5 }
        };

        public int ConvertRomanNumeralToDecimal(string numeral)
        {
            int count = 0;
            int dec;

            for (int i = 0; i < numeral.Length; i++)
            {
                dec = CharToDec(numeral[i]);
                if (i < numeral.Length - 1 && dec < CharToDec(numeral[i + 1]))
                {
                    count -= dec;
                }
                else
                {
                    count += dec;
                }
            }

            return count;
        }

        private int CharToDec(char numeral)
        {
            return _roman2Decimal[Convert.ToString(numeral)];
        }
    }
}


