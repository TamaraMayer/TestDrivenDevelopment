using NUnit.Framework;

namespace StringCalulator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddMethod_Should_Return_Zero_For_Emty_String()
        {
            Assert.Pass();
        }
    }
}