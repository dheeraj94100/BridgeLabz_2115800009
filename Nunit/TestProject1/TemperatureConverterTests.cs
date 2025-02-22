using NUnit.Framework;
using MyLibrary;

public class TemperatureConverterTests
    {
        private TemperatureConverter _converter;

        [SetUp]
        public void Setup()
        {
            _converter = new TemperatureConverter();
        }

        [Test]
        public void TestCelsiusToFahrenheit()
        {
            Assert.AreEqual(32, _converter.CelsiusToFahrenheit(0));
            Assert.AreEqual(212, _converter.CelsiusToFahrenheit(100));
        }

        [Test]
        public void TestFahrenheitToCelsius()
        {
            Assert.AreEqual(0, _converter.FahrenheitToCelsius(32));
            Assert.AreEqual(100, _converter.FahrenheitToCelsius(212));
        }
    }

