using System;

namespace InventoryManagement
{
    public class Item
    {
        public string ItemName { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Item Next { get; set; }

        public Item(string itemName, int itemId, int quantity, double price)
        {
            ItemName = itemName;
            ItemID = itemId;
            Quantity = quantity;
            Price = price;
            Next = null;
        }
    }

    public class Inventory
    {
        private Item head;

        public Inventory()
        {
            head = null;
        }

        public void AddItemAtBeginning(string itemName, int itemId, int quantity, double price)
        {
            Item newItem = new Item(itemName, itemId, quantity, price);
            newItem.Next = head;
            head = newItem;
        }

        public void AddItemAtEnd(string itemName, int itemId, int quantity, double price)
        {
            Item newItem = new Item(itemName, itemId, quantity, price);
            if (head == null)
            {
                head = newItem;
                return;
            }
            Item current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newItem;
        }

        public void AddItemAtPosition(string itemName, int itemId, int quantity, double price, int position)
        {
            Item newItem = new Item(itemName, itemId, quantity, price);
            if (position == 0)
            {
                newItem.Next = head;
                head = newItem;
                return;
            }
            Item current = head;
            for (int i = 0; i < position - 1 && current != null; i++)
            {
                current = current.Next;
            }
            if (current == null)
            {
                throw new ArgumentOutOfRangeException("position", "Position is out of range");
            }
            newItem.Next = current.Next;
            current.Next = newItem;
        }

        public void RemoveItemById(int itemId)
        {
            if (head == null) return;
            if (head.ItemID == itemId)
            {
                head = head.Next;
                return;
            }
            Item current = head;
            while (current.Next != null && current.Next.ItemID != itemId)
            {
                current = current.Next;
            }
            if (current.Next == null) return;
            current.Next = current.Next.Next;
        }

        public void UpdateQuantityById(int itemId, int newQuantity)
        {
            Item current = head;
            while (current != null)
            {
                if (current.ItemID == itemId)
                {
                    current.Quantity = newQuantity;
                    return;
                }
                current = current.Next;
            }
        }

        public Item SearchItemById(int itemId)
        {
            Item current = head;
            while (current != null)
            {
                if (current.ItemID == itemId)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public Item SearchItemByName(string itemName)
        {
            Item current = head;
            while (current != null)
            {
                if (current.ItemName.Equals(itemName, StringComparison.OrdinalIgnoreCase))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public double CalculateTotalValue()
        {
            double totalValue = 0;
            Item current = head;
            while (current != null)
            {
                totalValue += current.Price * current.Quantity;
                current = current.Next;
            }
            return totalValue;
        }

        public void SortInventoryByName(bool ascending = true)
        {
            if (head == null || head.Next == null) return;
            head = MergeSort(head, (a, b) => ascending ? string.Compare(a.ItemName, b.ItemName) < 0 : string.Compare(a.ItemName, b.ItemName) > 0);
        }

        public void SortInventoryByPrice(bool ascending = true)
        {
            if (head == null || head.Next == null) return;
            head = MergeSort(head, (a, b) => ascending ? a.Price < b.Price : a.Price > b.Price);
        }

        private Item MergeSort(Item head, Func<Item, Item, bool> comparison)
        {
            if (head == null || head.Next == null) return head;

            Item middle = GetMiddle(head);
            Item nextOfMiddle = middle.Next;
            middle.Next = null;

            Item left = MergeSort(head, comparison);
            Item right = MergeSort(nextOfMiddle, comparison);

            return SortedMerge(left, right, comparison);
        }

        private Item GetMiddle(Item head)
        {
            if (head == null) return head;

            Item slow = head, fast = head.Next;
            while (fast != null)
            {
                fast = fast.Next;
                if (fast != null)
                {
                    slow = slow.Next;
                    fast = fast.Next;
                }
            }
            return slow;
        }

        private Item SortedMerge(Item a, Item b, Func<Item, Item, bool> comparison)
        {
            if (a == null) return b;
            if (b == null) return a;

            Item result;
            if (comparison(a, b))
            {
                result = a;
                result.Next = SortedMerge(a.Next, b, comparison);
            }
            else
            {
                result = b;
                result.Next = SortedMerge(a, b.Next, comparison);
            }
            return result;
        }

        public void DisplayInventory()
        {
            Item current = head;
            while (current != null)
            {
                Console.WriteLine($"Item Name: {current.ItemName}, Item ID: {current.ItemID}, Quantity: {current.Quantity}, Price: {current.Price}");
                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            inventory.AddItemAtBeginning("Item1", 1, 10, 5.5);
            inventory.AddItemAtEnd("Item2", 2, 20, 15.0);
            inventory.AddItemAtPosition("Item3", 3, 30, 25.0, 1);
            inventory.DisplayInventory();

            Console.WriteLine("Total Inventory Value: " + inventory.CalculateTotalValue());

            inventory.SortInventoryByName();
            Console.WriteLine("Sorted by Name:");
            inventory.DisplayInventory();

            inventory.SortInventoryByPrice(false);
            Console.WriteLine("Sorted by Price Descending:");
            inventory.DisplayInventory();
        }
    }
}