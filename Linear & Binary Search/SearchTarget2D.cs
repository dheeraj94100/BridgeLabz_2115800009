using System;

class Program
{
    static void Main()
    {
        // Input the matrix from the user
        Console.Write("Enter the number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            Console.Write($"Enter row {i + 1} (space-separated): ");
            string[] rowValues = Console.ReadLine().Split(' ');

            for (int j = 0; j < cols; j++)
            {
                matrix[i, j] = Convert.ToInt32(rowValues[j]);
            }
        }

        // Input the target value
        Console.Write("Enter the target value to search: ");
        int target = Convert.ToInt32(Console.ReadLine());

        // Perform the search
        bool found = SearchIn2DMatrix(matrix, target, out int row, out int col);

        // Display the result
        if (found)
        {
            Console.WriteLine($"Target {target} found at position: ({row}, {col})");
        }
        else
        {
            Console.WriteLine($"Target {target} not found in the matrix.");
        }
    }

    static bool SearchIn2DMatrix(int[,] matrix, int target, out int row, out int col)
    {
        row = -1;
        col = -1;

        if (matrix == null || matrix.Length == 0)
        {
            return false;
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Treat the 2D matrix as a 1D array
        int left = 0;
        int right = rows * cols - 1;

        while (left <= right)
        {
            int mid = (left + right) / 2;
            // Convert 1D index to 2D indices
            int midRow = mid / cols;
            int midCol = mid % cols;
            int midValue = matrix[midRow, midCol];

            if (midValue == target)
            {
                row = midRow;
                col = midCol;
                return true;
            }
            else if (midValue < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return false;
    }
}