using System;
using System.Threading;

namespace MyLibrary
{
    public class PerformanceTester
    {
        public string LongRunningTask()
        {
            Thread.Sleep(3000); // Simulates a delay of 3 seconds
            return "Completed";
        }
    }
}
