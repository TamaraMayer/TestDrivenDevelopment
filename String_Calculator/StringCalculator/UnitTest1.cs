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
           Assert.AreEqual(0,String_Calculator.StringCalculator.Add(string.Empty));
        }

        [DataTestMethod]
        [DataRow ("1")]
        [DataRow("2")]
        [DataRow("5")]
        [DataRow("10")]
        public void Add_Should_Return_The_Given_Number(string numberString)
        {
            Assert.AreEqual(Int32.Parse(numberString), String_Calculator.StringCalculator.Add(numberString));
        }

        [DataTestMethod]
        [DataRow ("1,2", 3)]
        [DataRow("2,2", 4)]
        [DataRow ("1,3",4)]
        public void Add_Should_Return_Two_Numers_added(string numberString, int solution)
        {
            Assert.AreEqual(solution, String_Calculator.StringCalculator.Add(numberString));
        }

        [DataTestMethod]
        [DataRow("1,2,3", 6)]
        [DataRow("1,2,4", 7)]

        public void Add_Should_Return_The_added_numbers_no_matter_how_many_numbers(string numberString, int solution)
        {
            Assert.AreEqual(solution, String_Calculator.StringCalculator.Add(numberString));
        }
    }
}
