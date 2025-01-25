using System;

class Program
{
    static void Main()
    {
        // Get dimensions of the 2D array
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        // Initialize the 2D array
        int[,] matrix = new int[rows, cols];
        Console.WriteLine("Enter the elements of the matrix:");

        // Input the matrix elements
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Copy 2D array into 1D array
        int[] array = new int[rows * cols];
        int index = 0;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[index++] = matrix[i, j];
            }
        }

        // Display the 1D array
        Console.WriteLine("1D Array: " + string.Join(", ", array));
    }
}
