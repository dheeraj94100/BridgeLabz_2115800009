using System;
using System.Collections.Generic;

class SlidingWindowMaximum
{
    public static int[] MaxSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k == 0)
        {
            return new int[0];
        }

        int n = nums.Length;
        int[] result = new int[n - k + 1];
        Deque<int> deque = new Deque<int>(); // Stores indices of useful elements
        int resultIndex = 0;

        for (int i = 0; i < n; i++)
        {
            // Remove indices that are out of this window
            if (deque.Count > 0 && deque.PeekFront() <= i - k)
            {
                deque.PopFront();
            }

            // Remove indices whose corresponding values are smaller than the current element
            while (deque.Count > 0 && nums[deque.PeekBack()] <= nums[i])
            {
                deque.PopBack();
            }

            // Add the current index to the deque
            deque.PushBack(i);

            // The deque contains the largest element's index at the front for each window
            if (i >= k - 1)
            {
                result[resultIndex++] = nums[deque.PeekFront()];
            }
        }

        return result;
    }

    static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] result = MaxSlidingWindow(nums, k);

        Console.WriteLine("Sliding Window Maximums:");
        foreach (var num in result)
        {
            Console.Write(num + " ");
        }
    }
}

// Custom Deque implementation to store indices
public class Deque<T>
{
    private LinkedList<T> list = new LinkedList<T>();

    public void PushBack(T value)
    {
        list.AddLast(value);
    }

    public void PopBack()
    {
        list.RemoveLast();
    }

    public T PeekBack()
    {
        return list.Last.Value;
    }

    public void PushFront(T value)
    {
        list.AddFirst(value);
    }

    public void PopFront()
    {
        list.RemoveFirst();
    }

    public T PeekFront()
    {
        return list.First.Value;
    }

    public int Count => list.Count;
}
