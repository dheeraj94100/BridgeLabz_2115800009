using NUnit.Framework;
using MyLibrary;

namespace CalculatorTests
{
    public class PerformanceTests
    {
        private PerformanceTester _tester;

        [SetUp]
        public void Setup()
        {
            _tester = new PerformanceTester();
        }

        [Test, Timeout(2000)]  // This test should fail because the task takes 3 sec
        public void TestLongRunningTask()
        {
            _tester.LongRunningTask();
        }
    }
}
