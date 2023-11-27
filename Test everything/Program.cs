using System;

class MatrixSwapper
{
    static void Main()
    {
        int[][] matrix = {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] {9, 10, 11, 12},
            new int[] {13, 14, 15, 16}
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(matrix);

        // Example: Swap elements at (0, 0), (0, 1), (1, 0), and (1, 1)
        SwapElements(matrix, 0, 0, 1, 0, 1, 1, 0, 1);

        Console.WriteLine("\nMatrix after swapping elements:");
        PrintMatrix(matrix);
    }

    static void SwapElements(int[][] matrix, int row1, int col1, int row2, int col2, int row3, int col3, int row4, int col4)
    {
        int temp = matrix[row4][col4];
        matrix[row4][col4] = matrix[row3][col3];
        matrix[row3][col3] = matrix[row2][col2];
        matrix[row2][col2] = matrix[row1][col1];
        matrix[row1][col1] = temp;
    }

    static void PrintMatrix(int[][] matrix)
    {
        foreach (var row in matrix)
        {
            foreach (var element in row)
            {
                Console.Write(element + "\t");
            }
            Console.WriteLine();
        }
    }
}
