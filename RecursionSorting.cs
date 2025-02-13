using System;

class SortStack
{
    private int[] stack;
    private int top;
    private int size;

    public SortStack(int capacity)
    {
        size = capacity;
        stack = new int[size];
        top = -1; // Initialize stack as empty
    }

    // Push an element onto the stack
    public void Push(int item)
    {
        if (top == size - 1)
        {
            Console.WriteLine("Stack overflow");
            return;
        }
        stack[++top] = item;
    }

    // Pop the top element from the stack
    public int Pop()
    {
        return IsEmpty() ? -1 : stack[top--];
    }

    public bool IsEmpty()
    {
        return top == -1;
    }

    public int Peek()
    {
        return IsEmpty() ? -1 : stack[top];
    }

    // Recursive function to sort the stack
    public void Sort()
    {
        if (!IsEmpty())
        {
            int temp = Pop(); // Remove top element
            Sort(); // Recursively sort the remaining stack
            InsertSorted(temp); // Insert the element back in sorted order
        }
    }

    // Insert an element in a sorted stack
    private void InsertSorted(int item)
    {
        if (IsEmpty() || Peek() <= item)
        {
            Push(item);
            return;
        }

        int temp = Pop();
        InsertSorted(item); // Recursively insert at correct position
        Push(temp); // Restore popped elements
    }

    public void PrintStack()
    {
        for (int i = top; i >= 0; i--)
            Console.Write(stack[i] + " ");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        SortStack stack = new SortStack(5);

        stack.Push(3);
        stack.Push(1);
        stack.Push(4);
        stack.Push(2);
        stack.Push(5);

        Console.WriteLine("Original Stack:");
        stack.PrintStack();

        stack.Sort();

        Console.WriteLine("Sorted Stack:");
        stack.PrintStack();
    }
}
