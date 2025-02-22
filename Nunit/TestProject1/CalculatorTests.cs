using NUnit.Framework;
using MyLibrary;

namespace MyLibrary.Tests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }

        [Test]
        public void TestAdd() => Assert.AreEqual(5, _calculator.Add(2, 3));

        [Test]
        public void TestSubtract() => Assert.AreEqual(1, _calculator.Subtract(3, 2));

        [Test]
        public void TestMultiply() => Assert.AreEqual(6, _calculator.Multiply(2, 3));

        [Test]
        public void TestDivide() => Assert.AreEqual(2, _calculator.Divide(6, 3));

        [Test]
        public void TestDivideByZero() => Assert.Throws<DivideByZeroException>(() => _calculator.Divide(6, 0));
    }
}
