using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace PrintNumbers
{
    public static class NumberToText
    {
        private static string EnglishTextNumber;


        static Dictionary<int, string> texTDictionary = new Dictionary<int, string>(){
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



        public static string ToEnglishText(this int Number)
        {
            EnglishTextNumber = String.Empty;
            Spiltconcatenation(Number);
            return EnglishTextNumber.Trim();
        }

        private static void Spiltconcatenation(int number)
        {
            int[] numberArray = number.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            int TenThousand = number%10000;

            int Thousand = number%1000;

            int Hundred = number%100;


            if (TenThousand >= 10000)
            {
                WordBuilder(Convert.ToInt32(numberArray[0].ToString() + numberArray[1].ToString()));
                WordBuilder(1000);
                if (Thousand > 0)
                    Spiltconcatenation(TenThousand);
            }
            else if (number >= 1000)
            {
                WordBuilder(numberArray[0]);
                WordBuilder(1000);
                if (Thousand > 0)
                Spiltconcatenation(Thousand);
            }else if (number >= 100)
            {
                WordBuilder(numberArray[0]);
                WordBuilder(100);
                if (Hundred > 0)
                Spiltconcatenation(Hundred);
            }else if (number >= 21)
            {
                WordBuilder(Convert.ToInt32(numberArray[0] + "0"));
                WordBuilder(numberArray[1]);

            }
            else
            {

                WordBuilder(number);
            }
        }

         private static void WordBuilder(int number){
            EnglishTextNumber += " " + texTDictionary[number];
        }

    }
}
