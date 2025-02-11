using System;

public class TextEditor
{
    private class Node
    {
        public string Text { get; set; }
        public Node Prev { get; set; }
        public Node Next { get; set; }

        public Node(string text)
        {
            Text = text;
        }
    }

    private Node head;
    private Node tail;
    private Node current;
    private int size;
    private const int MaxSize = 10;

    public TextEditor()
    {
        head = tail = current = null;
        size = 0;
    }

    public void AddState(string text)
    {
        Node newNode = new Node(text);

        if (head == null)
        {
            head = tail = current = newNode;
        }
        else
        {
            if (current.Next != null)
            {
                current.Next.Prev = null;
                current.Next = null;
            }

            current.Next = newNode;
            newNode.Prev = current;
            current = newNode;
            tail = newNode;

            if (size == MaxSize)
            {
                head = head.Next;
                head.Prev = null;
            }
            else
            {
                size++;
            }
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
        {
            Console.WriteLine("Current State: " + current.Text);
        }
        else
        {
            Console.WriteLine("No state available.");
        }
    }
}

class Program
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("State 1");
        editor.AddState("State 2");
        editor.AddState("State 3");

        editor.DisplayCurrentState(); // Output: Current State: State 3

        editor.Undo();
        editor.DisplayCurrentState(); // Output: Current State: State 2

        editor.Redo();
        editor.DisplayCurrentState(); // Output: Current State: State 3

        editor.Undo();
        editor.Undo();
        editor.DisplayCurrentState(); // Output: Current State: State 1

        editor.Redo();
        editor.DisplayCurrentState(); // Output: Current State: State 2
    }
}