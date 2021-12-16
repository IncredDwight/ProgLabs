using System;

namespace ProgLab8
{
    class ProgLab8
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter square matrix length: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = GenerateMatrix(n);

            SortMatrix(matrix);

            int[] diagonal = GetMatrixDiagonal(matrix);
        }

        static int[,] GenerateMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, j] = new Random().Next(-100, 100);
                }
            }
            return matrix;
        }

        static void SortMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[0, j - 1] < matrix[0, j])
                        SwapRows(matrix, j - 1, j);
                }
            }
        }

        static void SwapRows(int[,] matrix, int firstRaw, int secondRaw)
        {
            int currentCell;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                currentCell = matrix[i, firstRaw];
                matrix[i, firstRaw] = matrix[i, secondRaw];
                matrix[i, secondRaw] = currentCell;
            }
        }

        static int[] GetMatrixDiagonal(int[,] matrix)
        {
            int[] diagonal = new int[matrix.GetLength(0)];
            for (int i = 0; i < diagonal.Length; i++)
                diagonal[i] = matrix[i, i];
            return diagonal;
        }
    }
}
