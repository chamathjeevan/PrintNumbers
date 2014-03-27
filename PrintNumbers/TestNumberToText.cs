using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace PrintNumbers
{

    public class TestNumberToText
    {

     //   [TestCase(0, "")]
        [TestCase(1, "One")]
        [TestCase(2, "Two")]
        [TestCase(3, "Three")]
        [TestCase(4, "Four")]
        [TestCase(5, "Five")]
        [TestCase(6, "Six")]
        [TestCase(7, "Seven")]
        [TestCase(8, "Eight")]
        [TestCase(9, "Nine")]
        [TestCase(10, "Ten")]
        [TestCase(11, "Eleven")]
        [TestCase(12, "Twelve")]
        [TestCase(13, "Thirteen")]
        [TestCase(14, "Fourteen")]
        [TestCase(15, "Fifteen")]
        [TestCase(16, "Sixteen")]
        [TestCase(17, "Seventeen")]
        [TestCase(18, "Eighteen")]
        [TestCase(19, "Nineteen")]
        [TestCase(20, "Twenty")]
        [TestCase(21, "Twenty One")]
        [TestCase(30, "Thirty")]
        [TestCase(40, "Forty")]
        [TestCase(47, "Forty Seven")]
        [TestCase(50, "Fifty")]
        [TestCase(60, "Sixty")]
        [TestCase(70, "Seventy")]
        [TestCase(80, "Eighty")]
        [TestCase(90, "Ninety")]
         [TestCase(98, "Ninety Eight")]
         [TestCase(100, "One Hundred")]
        [TestCase(200, "Two Hundred")]
        [TestCase(1000, "One Thousand")]
        [TestCase(8576, "Eight Thousand Five Hundred Seventy Six")]
        [TestCase(76897, "Seventy Six Thousand Eight Hundred Ninety Seven")]
        [TestCase(234566786, "Two Hundred Thirty Four Million Five Hundred Sixty Six Thousand Seven Hundred Eighty Six")]
        public void ShouldConvertToEnglishText(int number, string englishText)
        {
            number.ToEnglishWords().Should().Be(englishText);
        }
    }
}
