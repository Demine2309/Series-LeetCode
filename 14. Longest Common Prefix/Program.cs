namespace SeriesLeetcode
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            string shortest = strs[0];
            foreach (string str in strs)
            {
                if (str.Length < shortest.Length)
                {
                    shortest = str;
                }
            }
             
            for (int i = 0; i < shortest.Length; i++)
            {
                char currentChar = shortest[i];

                foreach (string str in strs)
                {
                    if (str[i] != currentChar)
                    {
                        shortest = shortest.Substring(0, i);
                    }
                }
            }

            return shortest;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string[] strs = { "dlowdasd", "flow", "klowdasd" };
            string result = solution.LongestCommonPrefix(strs);
            Console.WriteLine(result);

        }
    }
}

/*
 * Example 1:
    Input: strs = ["flower", "flow", "flight"]
    Output: "fl"

 * Example 2:
    Input: strs = ["dog", "racecar", "car"]
    Output: ""
    Explanation: There is no common prefix among the input strings.
*/