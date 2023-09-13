using System;
namespace Roman_Numerals_Translator.Seed
{
	public static class RomanNumeralSeeds
	{
        public static Dictionary<string, int> GetRomanNumeralValues()
        {
            return new Dictionary<string, int>
        {
            { "I", 1 },
            { "IV", 4 },
            { "V", 5 },
            { "IX", 9 },
            { "X", 10 },
            { "XL", 40 },
            { "L", 50 },
            { "XC", 90 },
            { "C", 100 },
            { "CD", 400 },
            { "D", 500 },
            { "CM", 900 },
            { "M", 1000 }
        };
        }
    }
}

