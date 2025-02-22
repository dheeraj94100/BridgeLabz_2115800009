using NUnit.Framework;
using System;
using MyLibrary;  

public class Calculator2Tests
    {
        private Calculator2 _calculator;

        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator2();
        }

        [Test]
        public void TestDivide_ValidNumbers()
        {
            Assert.AreEqual(2, _calculator.Divide(6, 3));
        }

        [Test]
        public void TestDivideByZero_ThrowsException()
        {
            Assert.Throws<ArithmeticException>(() => _calculator.Divide(6, 0));
        }
    }

