namespace SeriesLeetCode
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            char[] romanNumerals = { 'I', 'V', 'X', 'L', 'C', 'D', 'M' };
            int[] values = { 1, 5, 10, 50, 100, 500, 1000 };
            int result = 0;

            for (int i = 0; i < s.Length; i++)
            {
                char currentChar = s[i];
                int currentValue = values[Array.IndexOf(romanNumerals, currentChar)];

                int nextValue = 0;
                if (i + 1 < s.Length)
                {
                    char nextChar = s[i + 1];
                    nextValue = values[Array.IndexOf(romanNumerals, nextChar)];
                }

                if (currentValue < nextValue)
                {
                    result -= currentValue;
                }
                else
                {
                    result += currentValue;
                }
            }

            return result;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "MCMXCIV";
            int result = solution.RomanToInt(s);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: s = "III"
    Output: 3
    Explanation: III = 3.

 * Example 2:
    Input: s = "LVIII"
    Output: 58
    Explanation: L = 50, V= 5, III = 3.

 * Example 3:
    Input: s = "MCMXCIV"
    Output: 1994
    Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
*/