using NUnit.Framework;
using MyLibrary;

public class PasswordValidatorTests
    {
        private PasswordValidator _validator;

        [SetUp]
        public void Setup()
        {
            _validator = new PasswordValidator();
        }

        [TestCase("Pass1234", true)]
        [TestCase("password", false)]
        [TestCase("12345678", false)]
        [TestCase("SHORT1", false)]
        [TestCase("ValidPass1", true)]
        public void TestPasswordValidation(string password, bool expected)
        {
            bool result = _validator.IsValidPassword(password);
            Assert.AreEqual(expected, result);
        }
    }
