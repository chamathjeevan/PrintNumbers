using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace PrintNumbers
{
    public static class NumberToText
    {
        private static string _numberInEnglishWords;

        static Dictionary<int, string> wordsOfEnglishNumbers = new Dictionary<int, string>(){
                                                                    {0,""},
                                                                    {1,"One"},
                                                                    {2,"Two"},
                                                                    {3,"Three"},
                                                                    {4,"Four"},
                                                                    {5,"Five"},
                                                                    {6,"Six"},
                                                                    {7,"Seven"},
                                                                    {8,"Eight"},
                                                                    {9,"Nine"},
                                                                    {10,"Ten"},
                                                                    {11,"Eleven"},
                                                                    {12,"Twelve"},
                                                                    {13,"Thirteen"},
                                                                    {14,"Fourteen"},
                                                                    {15,"Fifteen"},
                                                                    {16,"Sixteen"},
                                                                    {17,"Seventeen"},
                                                                    {18,"Eighteen"},
                                                                    {19,"Nineteen"},
                                                                    {20,"Twenty"},
                                                                    {30,"Thirty"},
                                                                    {40,"Forty"},
                                                                    {50,"Fifty"},
                                                                    {60,"Sixty"},
                                                                    {70,"Seventy"},
                                                                    {80,"Eighty"},
                                                                    {90,"Ninety"},
                                                                    {100,"Hundred"},
                                                                    {1000,"Thousand"},
                                                                    {1000000,"Million"},
                                                                     };



        public static string ToEnglishWords(this int numberToConvert)
        {
            _numberInEnglishWords = String.Empty;
            EnglishNumberBuilder(numberToConvert);
            return _numberInEnglishWords.Trim();
        }

        private static void EnglishNumberBuilder(int number)
        {
            if (number == 0) return;

            if (number >= 1000000)
            {
                AddWords(number, 1000000);

            }else if (number >= 1000)
            {
                AddWords(number, 1000);
            }
            else if (number >= 100)
            {
                AddWords(number, 100);
            }
            else if (number > 20)
            {
                AddWords(number, 10);
            }
            else
            {
                AddWords(number, 1);
            }
        }

        private static void AddWords(int number, int dividerFactor)
        {
            int remainder = number % dividerFactor;

            int factorCount = (number - remainder) / dividerFactor;

            if (factorCount != 0 && dividerFactor > 10) EnglishNumberBuilder(factorCount);

            if (dividerFactor%10 == 0)
            {
                _numberInEnglishWords += " " + wordsOfEnglishNumbers[(dividerFactor == 10 ? factorCount : 1) * dividerFactor];
            }
            else
            {
                _numberInEnglishWords += " " + wordsOfEnglishNumbers[number];
            }

            EnglishNumberBuilder(remainder);
        }
    }
}
