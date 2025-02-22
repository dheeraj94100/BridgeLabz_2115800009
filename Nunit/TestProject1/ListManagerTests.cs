using NUnit.Framework;
using System.Collections.Generic;
using MyLibrary;

namespace MyLibrary.Tests
{
    public class ListManagerTests
    {
        private ListManager _listManager;
        private List<int> _testList;

        [SetUp]
        public void Setup()
        {
            _listManager = new ListManager();
            _testList = new List<int>();  // Initialize a new empty list before each test
        }

        [Test]
        public void TestAddElement()
        {
            _listManager.AddElement(_testList, 5);
            Assert.Contains(5, _testList);
        }

        [Test]
        public void TestRemoveElement()
        {
            _testList.Add(10); 
            bool isRemoved = _listManager.RemoveElement(_testList, 10);
            Assert.IsTrue(isRemoved);
            Assert.IsFalse(_testList.Contains(10));
        }

        [Test]
        public void TestGetSize()
        {
            _listManager.AddElement(_testList, 1);
            _listManager.AddElement(_testList, 2);
            _listManager.AddElement(_testList, 3);
            Assert.AreEqual(3, _listManager.GetSize(_testList));
        }
    }
}
