using NUnit.Framework;
using MyLibrary;
using System;

public class UserRegistrationTests
    {
        private UserRegistration _registration;

        [SetUp]
        public void Setup()
        {
            _registration = new UserRegistration();
        }

        [Test]
        public void TestInvalidEmail()
        {
            Assert.Throws<ArgumentException>(() => _registration.RegisterUser("User", "invalid-email", "Password1"));
        }
    }

