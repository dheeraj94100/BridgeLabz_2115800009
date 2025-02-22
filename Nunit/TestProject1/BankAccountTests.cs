using NUnit.Framework;
using MyLibrary;
using System;
public class BankAccountTests
    {
        private BankAccount _account;

        [SetUp]
        public void Setup()
        {
            _account = new BankAccount(100);
        }

        [Test]
        public void TestDeposit()
        {
            _account.Deposit(50);
            Assert.AreEqual(150, _account.GetBalance());
        }

        [Test]
        public void TestWithdraw()
        {
            _account.Withdraw(30);
            Assert.AreEqual(70, _account.GetBalance());
        }

        [Test]
        public void TestWithdrawInsufficientFunds()
        {
            Assert.Throws<InvalidOperationException>(() => _account.Withdraw(200));
        }
    }

