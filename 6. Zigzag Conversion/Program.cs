using System.Text;

namespace SeriesLeetCode
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
            {
                return s;
            }

            var output = new StringBuilder(s.Length);

            var period = numRows * 2 - 2;

            for (int row = 0; row < numRows; ++row)
            {
                var increment = 2 * row;

                for (int i = row; i < s.Length; i += increment)
                {
                    output.Append(s[i]);

                    if (increment != period)
                    {
                        increment = period - increment;
                    }
                }
            }

            return output.ToString(); ;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "AB";
            int numRows = 1;

            string result = solution.Convert(s, numRows);
            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: s = "PAYPALISHIRING", numRows = 3
    Output: "PAHNAPLSIIGYIR"

 * Example 2:
    Input: s = "PAYPALISHIRING", numRows = 4
    Output: "PINALSIGYAHRPI"
    Explanation:
    P     I    N
    A   L S  I G
    Y A   H R
    P     I

 * Example 3:
    Input: s = "A", numRows = 1
    Output: "A"
 */