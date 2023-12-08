namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            IList<int> result = new List<int>();

            Recursivecall(matrix, 0, matrix.Length - 1, 0, matrix[0].Length - 1, result);

            return result;
        }

        private void Recursivecall(int[][] matrix, int a, int b, int c, int d, IList<int> result)
        {
            if (a > b || c > d)
                return;

            for (int i = c; i <= d; i++)
            {
                result.Add(matrix[a][i]);
            }
            a++;

            for (int i = a; i <= b; i++)
            {
                result.Add(matrix[i][d]);
            }
            d--;

            if (a <= b)
            {
                for (int i = d; i >= c; i--)
                {
                    result.Add(matrix[b][i]);
                }
                b--;
            }

            if (c <= d)
            {
                for (int i = b; i >= a; i--)
                {
                    result.Add(matrix[i][c]);
                }
                c++;
            }

            Recursivecall(matrix, a, b, c, d, result);
        }

        public void PrintList(IList<int> list)
        {
            Console.Write("[ ");
            foreach (var l in list)
            {
                Console.Write(l);
                if (l != list.Last())
                {
                    Console.Write(",");
                }
            }
            Console.Write(" }");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[][] matrix =
            {
                new int[] { 1,2,3,4},
                new int[] { 5,6,7,8},
                new int[] { 9,10,11,12},
                new int[] { 13,14,15,16}
            };

            IList<int> result = solution.SpiralOrder(matrix);

            solution.PrintList(result);
        }
    }
}

/*
 * Example 1:
    Input: matrix = [[1,2,3],[4,5,6],[7,8,9]]
    Output: [1,2,3,6,9,8,7,4,5]

 * Example 2:
    Input: matrix = [[1,2,3,4],[5,6,7,8],[9,10,11,12]]
    Output: [1,2,3,4,8,12,11,10,9,5,6,7]
 */