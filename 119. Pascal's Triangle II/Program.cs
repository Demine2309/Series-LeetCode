namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            IList<IList<int>> triangle = new List<IList<int>>();

            for (int i = 0; i < rowIndex + 1; i++)
            {
                List<int> row = new List<int>();

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                        row.Add(1);
                    else
                    {
                        int prevSum = triangle[i - 1][j - 1] + triangle[i - 1][j];
                        row.Add(prevSum);
                    }
                }

                triangle.Add(row);
            }

            return triangle[triangle.Count - 1];
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int rowIndex = 3;

            IList<int> result = solution.GetRow(rowIndex);

            foreach (var num in result)
            {
                Console.Write(num + " ");
            }
        }
    }
}

/*
 * Example 1:
    Input: rowIndex = 3
    Output: [1,3,3,1]

 * Example 2:
    Input: rowIndex = 0
    Output: [1]

 * Example 3:
    Input: rowIndex = 1
    Output: [1,1]
*/