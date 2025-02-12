using System;
using System.Collections.Generic;

public class QueueUsingStacks<T>
{
    private Stack<T> stackEnqueue;
    private Stack<T> stackDequeue;

    public QueueUsingStacks()
    {
        stackEnqueue = new Stack<T>();
        stackDequeue = new Stack<T>();
    }

    public void Enqueue(T item)
    {
        stackEnqueue.Push(item);
    }

    public T Dequeue()
    {
        if (stackDequeue.Count == 0)
        {
            while (stackEnqueue.Count > 0)
            {
                stackDequeue.Push(stackEnqueue.Pop());
            }
        }

        if (stackDequeue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return stackDequeue.Pop();
    }

    public int Count
    {
        get { return stackEnqueue.Count + stackDequeue.Count; }
    }

    public bool IsEmpty
    {
        get { return Count == 0; }
    }
}

class Program
{
    static void Main()
    {
        QueueUsingStacks<int> queue = new QueueUsingStacks<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine(queue.Dequeue()); // Output: 1
        Console.WriteLine(queue.Dequeue()); // Output: 2

        queue.Enqueue(4);
        Console.WriteLine(queue.Dequeue()); // Output: 3
        Console.WriteLine(queue.Dequeue()); // Output: 4
    }
}