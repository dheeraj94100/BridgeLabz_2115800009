using NUnit.Framework;
using MyLibrary;

namespace MyLibrary.Tests
{
    public class StringUtilsTests
    {
        private StringUtils _stringUtils;

        [SetUp]
        public void Setup()
        {
            _stringUtils = new StringUtils();
        }

        [Test]
        public void TestReverse() => Assert.AreEqual("olleh", _stringUtils.Reverse("hello"));

        [Test]
        public void TestIsPalindrome()
        {
            Assert.IsTrue(_stringUtils.IsPalindrome("madam"));
            Assert.IsFalse(_stringUtils.IsPalindrome("hello"));
        }

        [Test]
        public void TestToUpperCase() => Assert.AreEqual("HELLO", _stringUtils.ToUpperCase("hello"));
    }
}
