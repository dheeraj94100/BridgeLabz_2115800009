using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Enter elements of the Queue separated by space: ");
        Queue<int> queue = new Queue<int>(Console.ReadLine()
                                   .Split(' ')
                                   .Select(x => Convert.ToInt32(x)));

        queue = ReverseQueue(queue);

        Console.WriteLine("Reversed Queue: [" + string.Join(", ", queue) + "]");
    }

    static Queue<int> ReverseQueue(Queue<int> queue)
    {
        Stack<int> stack = new Stack<int>();

        // Dequeue elements and push to stack
        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }

        // Pop elements from stack and enqueue back
        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }
}
