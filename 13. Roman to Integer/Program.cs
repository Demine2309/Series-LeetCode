namespace SeriesLeetCode
{
    public class Solution
    {
        public int RomanToInt(string s)
        {

        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "";
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