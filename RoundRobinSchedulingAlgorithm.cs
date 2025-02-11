using System;

public class Process
{
    public int ProcessID { get; set; }
    public int BurstTime { get; set; }
    public int Priority { get; set; }
    public Process Next { get; set; }

    public Process(int processID, int burstTime, int priority)
    {
        ProcessID = processID;
        BurstTime = burstTime;
        Priority = priority;
        Next = null;
    }
}

public class RoundRobinScheduling
{
    private Process head;
    private int timeQuantum;

    public RoundRobinScheduling(int timeQuantum)
    {
        this.timeQuantum = timeQuantum;
        head = null;
    }

    public void AddProcess(int processID, int burstTime, int priority)
    {
        Process newProcess = new Process(processID, burstTime, priority);
        if (head == null)
        {
            head = newProcess;
            head.Next = head;
        }
        else
        {
            Process temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newProcess;
            newProcess.Next = head;
        }
    }

    public void RemoveProcess(int processID)
    {
        if (head == null) return;

        Process current = head;
        Process previous = null;

        do
        {
            if (current.ProcessID == processID)
            {
                if (previous != null)
                {
                    previous.Next = current.Next;
                }
                else
                {
                    Process temp = head;
                    while (temp.Next != head)
                    {
                        temp = temp.Next;
                    }
                    head = head.Next;
                    temp.Next = head;
                }
                return;
            }
            previous = current;
            current = current.Next;
        } while (current != head);
    }

    public void Simulate()
    {
        if (head == null) return;

        int totalWaitingTime = 0;
        int totalTurnAroundTime = 0;
        int processCount = 0;

        Process current = head;
        do
        {
            processCount++;
            current = current.Next;
        } while (current != head);

        current = head;
        int currentTime = 0;

        while (true)
        {
            bool done = true;
            Process temp = current;

            do
            {
                if (temp.BurstTime > 0)
                {
                    done = false;
                    if (temp.BurstTime > timeQuantum)
                    {
                        currentTime += timeQuantum;
                        temp.BurstTime -= timeQuantum;
                    }
                    else
                    {
                        currentTime += temp.BurstTime;
                        totalWaitingTime += currentTime - temp.BurstTime;
                        totalTurnAroundTime += currentTime;
                        temp.BurstTime = 0;
                        RemoveProcess(temp.ProcessID);
                    }
                }
                temp = temp.Next;
            } while (temp != current);

            if (done) break;
        }

        Console.WriteLine("Average Waiting Time: " + (float)totalWaitingTime / processCount);
        Console.WriteLine("Average Turn-Around Time: " + (float)totalTurnAroundTime / processCount);
    }

    public void DisplayProcesses()
    {
        if (head == null) return;

        Process temp = head;
        do
        {
            Console.WriteLine("Process ID: " + temp.ProcessID + ", Burst Time: " + temp.BurstTime + ", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != head);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        RoundRobinScheduling scheduler = new RoundRobinScheduling(4);

        scheduler.AddProcess(1, 10, 1);
        scheduler.AddProcess(2, 5, 2);
        scheduler.AddProcess(3, 8, 1);

        Console.WriteLine("Initial Processes:");
        scheduler.DisplayProcesses();

        scheduler.Simulate();

        Console.WriteLine("Processes after simulation:");
        scheduler.DisplayProcesses();
    }
}