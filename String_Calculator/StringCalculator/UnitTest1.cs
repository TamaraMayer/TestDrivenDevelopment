using String_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace StringCalculator.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Should_Return_Zero_When_Given_An_EmtyList()
        {
            Assert.AreEqual(0, String_Calculator.StringCalculator.Add(string.Empty));
        }

        [DataTestMethod]
        [DataRow("1")]
        [DataRow("2")]
        [DataRow("5")]
        [DataRow("10")]
        public void Add_Should_Return_The_Given_Number(string numberString)
        {
            Assert.AreEqual(Int32.Parse(numberString), String_Calculator.StringCalculator.Add(numberString));
        }

        [DataTestMethod]
        [DataRow("1,2", 3)]
        [DataRow("2,2", 4)]
        [DataRow("1,3", 4)]
        public void Add_Should_Return_Two_Numers_added(string numberString, int solution)
        {
            Assert.AreEqual(solution, String_Calculator.StringCalculator.Add(numberString));
        }

        [DataTestMethod]
        [DataRow("1,2,3", 6)]
        [DataRow("1,2,4", 7)]
        [DataRow("1,2,3,1", 7)]

        public void Add_Should_Return_The_added_numbers_no_matter_how_many_numbers(string numberString, int solution)
        {
            Assert.AreEqual(solution, String_Calculator.StringCalculator.Add(numberString));
        }

        [DataTestMethod]
        [DataRow("1\n2,3", 6)]
        [DataRow("1\n2,4", 7)]
        [DataRow("1\n2\n4", 7)]

        public void Add_Should_Return_The_added_numbers_no_matter_how_many_numbers_numbers_may_be_split_With_newlines_or_commas(string numberString, int solution)
        {
            Assert.AreEqual(solution, String_Calculator.StringCalculator.Add(numberString));
        }

        [DataTestMethod]
        [DataRow("//;\n1;2", 3)]
        [DataRow("//;\n1;3", 4)]
        [DataRow("//t\n1t1t3", 5)]

        public void Add_Should_Retun_Added_Numbers_Ans_Support_Different_Deliminators(string numberString, int solution)
        {
            Assert.AreEqual(solution, String_Calculator.StringCalculator.Add(numberString));
        }

        [DataTestMethod]
        [DataRow("-1", "negatives not allowed: -1")]
        [DataRow("-3", "negatives not allowed: -3")]
        [DataRow("-1,-3", "negatives not allowed: -1,-3")]
        [DataRow("1,2,-3", "negatives not allowed: -3")]
        [DataRow("//t\n1t1t-5", "negatives not allowed: -5")]
        [DataRow("1\n2,-4", "negatives not allowed: -4")]
        public void Add_Called_With_Negative_Numbers_Should_Throw_Exception(string numberString, string expectedExceptionMessage)
        {
            string actualExceptionMessage = "";

            try
            {
                String_Calculator.StringCalculator.Add(numberString);
            }
            catch (ArgumentException e)
            {
                actualExceptionMessage += e.Message;
            }

            Assert.AreEqual(expectedExceptionMessage, actualExceptionMessage);
        }

        [DataTestMethod]
        [DataRow("2,1001", 2)]
        [DataRow("3,1000,1005", 1003)]
        [DataRow("//t\n1t1t1005", 2)]
        public void Add_Numbers_Bigger_1000_Should_be_ignored_For_Adding(string numberString, int solution)
        {
            Assert.AreEqual(solution, String_Calculator.StringCalculator.Add(numberString));
        }

        [DataTestMethod]
        [DataRow("//***\n1***2***3", 6)]
        public void Add_Deliminators_Can_Be_Of_Any_lengtj(string numberString, int solution)
        {
            Assert.AreEqual(solution, String_Calculator.StringCalculator.Add(numberString));
        }
    }
}
