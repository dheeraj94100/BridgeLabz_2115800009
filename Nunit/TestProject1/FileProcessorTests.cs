using NUnit.Framework;
using MyLibrary;
using System;
using System.IO;

namespace CalculatorTests
{
    public class FileProcessorTests
    {
        private FileProcessor _fileProcessor;
        private string _testFile = "testfile.txt";

        [SetUp]
        public void Setup()
        {
            _fileProcessor = new FileProcessor();
        }

        [TearDown]
        public void Cleanup()
        {
            if (File.Exists(_testFile))
                File.Delete(_testFile);
        }

        [Test]
        public void TestWriteAndReadFile()
        {
            string content = "Hello, NUnit!";
            _fileProcessor.WriteToFile(_testFile, content);
            string result = _fileProcessor.ReadFromFile(_testFile);

            Assert.AreEqual(content, result);
        }

        [Test]
        public void TestFileExistsAfterWrite()
        {
            _fileProcessor.WriteToFile(_testFile, "Sample Text");
            Assert.IsTrue(File.Exists(_testFile));
        }

        [Test]
        public void TestReadFromNonExistentFile()
        {
            Assert.Throws<FileNotFoundException>(() => _fileProcessor.ReadFromFile("nonexistent.txt"));
        }
    }
}
