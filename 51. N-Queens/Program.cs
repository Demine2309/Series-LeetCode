namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<IList<string>> SolveNQueens(int n)
        {
            IList<IList<string>> result = new List<IList<string>>();
            char[,] board = new char[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    board[i, j] = '.';
            }

            BackTrack(result, board, 0, n);
            return result;
        }

        private void BackTrack(IList<IList<string>> result, char[,] board, int row, int n)
        {
            if (row == n)
            {
                result.Add(BoardToList(board));
                return;
            }

            for (int col = 0; col < n; col++)
            {
                if (IsSafe(board, row, col, n))
                {
                    board[row, col] = 'Q';
                    BackTrack(result, board, row + 1, n);

                    board[row, col] = '.';
                }
            }
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

        private IList<string> BoardToList(char[,] board)
        {
            IList<string> result = new List<string>();
            int n = board.GetLength(0);

            for (int i = 0; i < n; i++)
            {
                string row = "";
                for (int j = 0; j < n; j++)
                {
                    row += board[i, j];
                }

                result.Add(row);
            }

            return result;
        }

        public void Print(IList<IList<string>> result)
        {
            foreach (var combination in result)
            {
                Console.Write("[");
                foreach (var element in combination)
                {
                    Console.Write(element);
                    if (element != combination.Last())
                    {
                        Console.Write(",");
                    }
                }
                Console.Write("] ");
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int n = 6;

            IList<IList<string>> result = solution.SolveNQueens(n);

            solution.Print(result);
        }
    }
}

/*
 * Example 1:
    Input: n = 4
    Output: [[".Q..","...Q","Q...","..Q."],["..Q.","Q...","...Q",".Q.."]]
    Explanation: There exist two distinct solutions to the 4-queens puzzle as shown above

 * Example 2:
    Input: n = 1
    Output: [["Q"]]
 */