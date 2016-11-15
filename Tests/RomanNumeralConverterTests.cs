using Kata_Roman_Numerals;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class DecimalNumeralTests
    {
        [TestCase("I", 1)]
        [TestCase("II", 2)]
        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("V", 5)]
     
        
        public void TheRomanNumeralIsConvertedToDecimalCorrectly(string romanNumber, int expected)
        {
            int actual = new RomanNumeralConverter().ConvertRomanNumeralToDecimal(romanNumber);
            Assert.AreEqual(expected, actual);
        }
    }
}

