using System;

namespace MatrixManipulation
{
    class Matrix
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
            int[,] matrix1 = CreateRandomMatrix(3, 3);
            int[,] matrix2 = CreateRandomMatrix(3, 3);

            Console.WriteLine("Matrix 1:");
            DisplayMatrix(matrix1);

            Console.WriteLine("Matrix 2:");
            DisplayMatrix(matrix2);

            Console.WriteLine("Addition:");
            DisplayMatrix(AddMatrices(matrix1, matrix2));

            Console.WriteLine("Subtraction:");
            DisplayMatrix(SubtractMatrices(matrix1, matrix2));

            Console.WriteLine("Multiplication:");
            DisplayMatrix(MultiplyMatrices(matrix1, matrix2));

            Console.WriteLine("Transpose of Matrix 1:");
            DisplayMatrix(TransposeMatrix(matrix1));

            Console.WriteLine("Determinant of 2x2 Matrix 1:");
            Console.WriteLine(Determinant2x2(matrix1));

            Console.WriteLine("Determinant of 3x3 Matrix 1:");
            Console.WriteLine(Determinant3x3(matrix1));

            Console.WriteLine("Inverse of 2x2 Matrix 1:");
            DisplayMatrix(Inverse2x2(matrix1));

            Console.WriteLine("Inverse of 3x3 Matrix 1:");
            DisplayMatrix(Inverse3x3(matrix1));
        }

        static int[,] CreateRandomMatrix(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i][j] = random.Next(1, 10);
                }
            }
            return matrix;
        }

        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }

        static int[,] SubtractMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            return result;
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix2.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = 0;
                    for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }

        static int[,] TransposeMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[j, i] = matrix[i, j];
                }
            }
            return result;
        }

        static int Determinant2x2(int[,] matrix)
        {
            return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }

        static int Determinant3x3(int[,] matrix)
        {
            int determinant = 0;
            for (int i = 0; i < 3; i++)
            {
                determinant += (matrix[0, i] * (matrix[1, (i + 1) % 3] * matrix[2, (i + 2) % 3] - matrix[1, (i + 2) % 3] * matrix[2, (i + 1) % 3]));
            }
            return determinant;
        }
        
        // A-Inverse = Adj(A) / det(A)
        static int[,] Inverse2x2(int[,] matrix)
        {
            int determinant = Determinant2x2(matrix);
            int[,] result = new int[2, 2];
            result[0, 0] = matrix[1, 1];
            result[0, 1] = -matrix[0, 1];
            result[1, 0] = -matrix[1, 0];
            result[1, 1] = matrix[0, 0];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] /= determinant;
                }
            }
            return result;
        }

        static int[,] Inverse3x3(int[,] matrix)
        {
            int determinant = Determinant3x3(matrix);
            int[,] result = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i, j] = ((matrix[(j + 1) % 3, (i + 1) % 3] * matrix[(j + 2) % 3, (i + 2) % 3]) - (matrix[(j + 1) % 3, (i + 2) % 3] * matrix[(j + 2) % 3, (i + 1) % 3])) / determinant;
                }
            }
            return result;
        }

        static void DisplayMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}