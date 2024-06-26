﻿namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
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

            return triangle;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int numRows = 6;
            IList<IList<int>> result = solution.Generate(numRows);

            foreach(var row in result)
            {
                Console.Write("[ ");
                foreach(var num in row)
                {
                    Console.Write(num + " ");
                }

                Console.Write("] ");
            }
        }
    }
}

/*
 * Example 1:
    Input: numRows = 5
    Output: [[1],[1,1],[1,2,1],[1,3,3,1],[1,4,6,4,1]]

 * Example 2:
    Input: numRows = 1
    Output: [[1]]
 */