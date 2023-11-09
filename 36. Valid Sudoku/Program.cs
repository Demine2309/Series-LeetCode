using System.Text;

namespace SeriesLeetCode
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (!Check1(board, i) || !Check2(board, i) || !Check3(board, i))
                {
                    return false;
                }
            }

            return true;
        }

        private bool Check1(char[][] board, int row)
        {
            bool[] visited = new bool[9];

            for (int j = 0; j < 9; j++)
            {
                char current = board[row][j];

                if (current != '.')
                {
                    int index = current - '1';

                    if (visited[index])
                        return false;

                    visited[index] = true;
                }
            }

            return true;
        }

        private bool Check2(char[][] board, int col)
        {
            bool[] visited = new bool[9];

            for (int i = 0; i < 9; i++)
            {
                char current = board[i][col];

                if (current != '.')
                {
                    int index = current - '1';

                    if (visited[index])
                        return false;

                    visited[index] = true;
                }
            }

            return true;
        }

        private bool Check3(char[][] board, int subGird)
        {
            bool[] visited = new bool[9];

            int startRow = (subGird / 3) * 3;
            int startCol = (subGird % 3) * 3;

            for (int i = startRow; i < startRow + 3; i++)
            {
                for (int j = startCol; j < startCol + 3; j++)
                {
                    char current = board[i][j];

                    if (current != '.')
                    {
                        int index = current - '1';

                        if (visited[index])
                            return false;

                        visited[index] = true;
                    }
                }
            }

            return true;

        }

        // My Way:
        //public bool IsValidSudoku(char[][] board)
        //{
        //    bool isValid = true;
        //    bool checkI = false, checkII = false;

        //    for (int i = 0; i < 9; i++)
        //    {
        //        bool check1 = Check1(board, i, 9);
        //        bool check2 = Check2(board, i, 9);

        //        if (check1 == false && check2 == false)
        //            checkI = true;
        //    }

        //    for (int k = 0; k < 6; k += 3)
        //    {
        //        bool check3 = Check3(board, k);
        //        if (check3 == false)
        //            checkII = true;
        //    }

        //    if (checkI == true && checkII == true)
        //        isValid = true;

        //    return isValid;
        //}

        //private bool Check1(char[][] board, int a, int n)
        //{
        //    bool isIterative = false;

        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        for (int j = i + 1; j < n; j++)
        //        {
        //            if (board[a][i] == board[a][j])
        //            {
        //                return isIterative = true;
        //                break;
        //            }
        //        }

        //        if (isIterative = true)
        //        {
        //            break;
        //        }
        //    }

        //    return isIterative;
        //}

        //private bool Check2(char[][] board, int b, int n)
        //{
        //    bool isIterative = false;

        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        for (int j = i + 1; j < n; j++)
        //        {
        //            if (board[i][b] == board[j][b])
        //            {
        //                return isIterative = true;
        //                break;
        //            }
        //        }

        //        if (isIterative = true)
        //        {
        //            break;
        //        }
        //    }

        //    return isIterative;
        //}

        //private bool Check3(char[][] board, int c)
        //{
        //    bool isIterative = false;

        //    for (int i = c; i < c + 3; i++)
        //    {
        //        bool check1 = Check1(board, i, 3);
        //        bool check2 = Check2(board, i, 3);

        //        if (check1 == true || check2 == true)
        //            isIterative = true;
        //    }

        //    return isIterative;
        //}
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            char[][] board = new char[][]
            {

            new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };


            bool result = solution.IsValidSudoku(board);

            Console.WriteLine(result);
        }
    }

}


/*
 * Example 1:
    Input: board = 
    [["5","3",".",".","7",".",".",".","."]
    ,["6",".",".","1","9","5",".",".","."]
    ,[".","9","8",".",".",".",".","6","."]
    ,["8",".",".",".","6",".",".",".","3"]
    ,["4",".",".","8",".","3",".",".","1"]
    ,["7",".",".",".","2",".",".",".","6"]
    ,[".","6",".",".",".",".","2","8","."]
    ,[".",".",".","4","1","9",".",".","5"]
    ,[".",".",".",".","8",".",".","7","9"]]
    Output: true

Example 2:
    Input: board = 
    [["8","3",".",".","7",".",".",".","."]
    ,["6",".",".","1","9","5",".",".","."]
    ,[".","9","8",".",".",".",".","6","."]
    ,["8",".",".",".","6",".",".",".","3"]
    ,["4",".",".","8",".","3",".",".","1"]
    ,["7",".",".",".","2",".",".",".","6"]
    ,[".","6",".",".",".",".","2","8","."]
    ,[".",".",".","4","1","9",".",".","5"]
    ,[".",".",".",".","8",".",".","7","9"]]
    Output: false
    Explanation: Same as Example 1, except with the 5 in the top left corner being modified to 8. Since there are two 8's in the top left 3x3 sub-box, it is invalid.
 */