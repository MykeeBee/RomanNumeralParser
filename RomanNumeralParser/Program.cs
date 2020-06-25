using System;
using System.Collections.Generic;

namespace RomanNumeralParser
{
    class Program
    {
        public static void Main(string[] args)
        {
            var Numerals = new Dictionary<char, int>();
            {
                Numerals.Add('I', 1);
                Numerals.Add('V', 5);
                Numerals.Add('X', 10);
                Numerals.Add('L', 50);
                Numerals.Add('C', 100);
                Numerals.Add('D', 500);
                Numerals.Add('M', 1000);
            }

            var romanString = "MMXX";
            var numeralToInt = 0;

            for (int i = 0; i < romanString.Length; i++)
            {
                if (i + 1 < romanString.Length && Numerals[romanString[i]] < Numerals[romanString[i + 1]])
                {
                    numeralToInt -= Numerals[romanString[i]];
                }
                else
                {
                    numeralToInt += Numerals[romanString[i]];
                }
            }

            Console.WriteLine(numeralToInt);
        }
    }
}
