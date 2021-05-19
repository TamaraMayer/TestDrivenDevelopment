using String_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void Add_Should_Return_The_Given_Number(string numberString)
        {
            Assert.AreEqual(1, String_Calculator.StringCalculator.Add(numberString));
        }
    }
}
