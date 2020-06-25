using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

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

            Regex regex = new Regex("^[MDCLXVI]+$");

            Console.WriteLine("Please enter a string of Roman Numerals");
            var romanString = Console.ReadLine().ToUpper();
            ^[MDCLXVI] +$
            Match match = regex.Match(romanString);

            if (match.Success)
            {
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
                Console.WriteLine(romanString + " is " + numeralToInt);
            }
            else
            {
                Console.WriteLine("Please enter a valid Roman Numeral string");
            }
        }
    }
}
