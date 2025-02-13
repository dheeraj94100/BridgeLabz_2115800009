using System;

class Dictionary
{
    class Node
    {
        public int Key;
        public int Value;
        public Node Next;

        public Node(int key, int value)
        {
            Key = key;
            Value = value;
            Next = null;
        }
    }

    private Node[] table;
    private int size;

    public Dictionary(int size)
    {
        this.size = size;
        table = new Node[size];
    }

    private int Hash(int key)
    {
        return key % size;
    }

    // Method to add key-value pair
    public void Add(int key, int value)
    {
        int index = Hash(key);
        Node newNode = new Node(key, value);

        if (table[index] == null)
        {
            table[index] = newNode;
        }
        else
        {
            Node current = table[index];
            while (current.Next != null)
            {
                if (current.Key == key)
                {
                    current.Value = value;  // Update value if the key already exists
                    return;
                }
                current = current.Next;
            }
            current.Next = newNode;  // Add the new node at the end
        }
    }

    // Method to get the value by key (equivalent to Dictionary's Get method)
    public int Get(int key)
    {
        int index = Hash(key);
        Node current = table[index];

        while (current != null)
        {
            if (current.Key == key)
            {
                return current.Value;
            }
            current = current.Next;
        }
        return -1;  // Return -1 if the key doesn't exist
    }

    // Method to remove a key-value pair (equivalent to Dictionary's Remove method)
    public void Remove(int key)
    {
        int index = Hash(key);
        Node current = table[index];
        Node prev = null;

        while (current != null)
        {
            if (current.Key == key)
            {
                if (prev == null)
                {
                    table[index] = current.Next;
                }
                else
                {
                    prev.Next = current.Next;
                }
                return;
            }
            prev = current;
            current = current.Next;
        }
    }

    static void Main()
    {
        Dictionary map = new Dictionary(10);
        map.Add(1, 100);
        map.Add(2, 200);
        map.Add(11, 300);  // Collision occurs, handled by chaining

        Console.WriteLine(map.Get(1));  // Output: 100
        map.Remove(1);
        Console.WriteLine(map.Get(1));  
    }
}

