using NUnit.Framework;
using MyLibrary;
using System;
public class DateFormatterTests
    {
        private DateFormatter _formatter;

        [SetUp]
        public void Setup()
        {
            _formatter = new DateFormatter();
        }

        [Test]
        public void TestValidDate()
        {
            Assert.AreEqual("25-12-2022", _formatter.FormatDate("2022-12-25"));
        }

        [Test]
        public void TestInvalidDate()
        {
            Assert.Throws<FormatException>(() => _formatter.FormatDate("invalid-date"));
        }
    }
