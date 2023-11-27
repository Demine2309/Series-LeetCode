namespace SeriesLeetCode
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.GetLength(0);

            int i = 0;
            int j = n - 1;

            while (i < j)
            {
                for (int k = i; k < j; k++)
                {
                    int l = j - (k - i);

                    // Counter-clockwise
                    Swap(matrix, k, i, j, k, l, j, i, j);

                    // clockwise
                    // Swap(matrix, i, k, k, j, j, l, l, i);
                }

                i++;
                j--;
            }
        }

        private void Swap(int[][] matrix, int row1, int col1, int row2, int col2, int row3, int col3, int row4, int col4)
        {
            int temp = matrix[row4][col4];
            matrix[row4][col4] = matrix[row3][col3];
            matrix[row3][col3] = matrix[row2][col2];
            matrix[row2][col2] = matrix[row1][col1];
            matrix[row1][col1] = temp;
        }


        public void PrintMatrix(int[][] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[][] matrix = new int[][]
            {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9}
            };

            solution.Rotate(matrix);

            solution.PrintMatrix(matrix);
        }
    }
}

/*
 * Example 1:
    Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
    Output: [[7,4,1],[8,5,2],[9,6,3]]

 * Example 2:
    Input: matrix = [[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]]
    Output: [[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]]
 */