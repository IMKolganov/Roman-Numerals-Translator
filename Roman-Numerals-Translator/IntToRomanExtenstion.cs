using System;
using System.Linq;
using System.Text;
using Roman_Numerals_Translator.Seed;

namespace Roman_Numerals_Translator
{

    /*
Create an implementation of a function that converts an integer input into a string, 
containing a valid roman number.
List of all possible roman literals: 
I             1
V             5
X             10
L             50
C             100
D             500
M             1000

I may go before V and X (10)
X may go before L (50) and C
C may go before D (500) and M

Table with all possible digits in roman system:
            1 2  3   4  5 6  7   8    9
1-9         I II III IV V VI VII VIII IX
10-90       X XX XXX XL L LX LXX LXXX XC
100-900     C CC CCC CD D DC DCC DCCC CM
1000-3000   M MM MMM

Examples:
11 => X I
123 => C XX III
498 => CD XC VIII
1987 => M CM LXXX VII
2023 => MM XX III

1645 => M DC XL V
504 => 

*/

    public static class IntToRomanExtenstion
    {
        public static string IntToRoman(this int num)
        {
            Dictionary<string, int> romanDict = RomanNumeralSeeds.GetRomanNumeralValues();


            if (num > 3999){
                throw new Exception("Invalid param max value in Roman 3999");
            }

            string[] symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            StringBuilder sb = new StringBuilder();

            //for (int i = 0; i < values.Length && num > 0; i++)
            //{
            //    while (values[i] <= num)
            //    {
            //        num -= values[i];
            //        sb.Append(symbols[i]);
            //    }
            //}
            return sb.ToString();
        }
    }
}

