using System;

class MatrixSwapper
{
    static void Main()
    {
        // Khởi tạo một ma trận 3x4
        int[][] matrix = {
            new int[] {1, 2, 3, 4},
            new int[] {5, 6, 7, 8},
            new int[] { 9, 10, 11, 12 },
            new int[] { 13, 14, 15, 16 },
            new int[] { 16, 17, 18, 19 }
        };

        // Lấy số hàng và số cột của ma trận
        int rows = matrix.Length;
        int columns = matrix[0].Length;

        // In kết quả
        Console.WriteLine("Số hàng của ma trận: " + rows);
        Console.WriteLine("Số cột của ma trận: " + columns);
    }
}
