using System.Text;

namespace SeriesLeetCode
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            string[] romanNumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            StringBuilder result = new StringBuilder();

            for (int i = 0; i < romanNumerals.Length; i++)
            {
                while (num >= values[i])
                {
                    result.Append(romanNumerals[i]);
                    num -= values[i];
                }
            }

            return result.ToString();
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int num = 2332;
            string result = solution.IntToRoman(num);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: num = 3
    Output: "III"
    Explanation: 3 is represented as 3 ones.

 * Example 2:
    Input: num = 58
    Output: "LVIII"
    Explanation: L = 50, V = 5, III = 3.

 * Example 3:
    Input: num = 1994
    Output: "MCMXCIV"
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
*/