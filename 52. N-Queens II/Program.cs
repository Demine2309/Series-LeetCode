namespace SeriesLeetCode
{
    public class Solution
    {
        public int TotalNQueens(int n)
        {
            char[,] board = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    board[i, j] = '.';
            }
            
            int result = BackTrack(board, 0, n);

            return result;

        }

        private int BackTrack(char[,] board, int row, int n)
        {
            if (row == n)
            {
                return 1;
            }

            int count = 0;

            for (int col = 0; col < n; col++)
            {
                if (IsSafe(board, row, col, n))
                {
                    board[row, col] = 'Q';
                    count += BackTrack(board, row + 1, n);
                    board[row, col] = '.';
                }
            }

            return count;
        }

        private bool IsSafe(char[,] board, int row, int col, int n)
        {
            for (int i = 0; i < row; i++)
            {
                if (board[i, col] == 'Q')
                    return false;
            }

            for (int i = row, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (board[i, j] == 'Q')
                    return false;
            }

            for (int i = row, j = col; i >= 0 && j < n; i--, j++)
            {
                if (board[i, j] == 'Q')
                    return false;
            }

            return true;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int n = 4;

            int result = solution.TotalNQueens(n);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: n = 4
    Output: 2
    Explanation: There are two distinct solutions to the 4-queens puzzle as shown.

 * Example 2:
    Input: n = 1
    Output: 1
 */