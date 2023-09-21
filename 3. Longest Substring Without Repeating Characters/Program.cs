namespace SeriesLeetCode
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            int start = 0;
            bool[] charSet = new bool[256];

            for(int end = 0; end < s.Length; end++)
            {
                char currentChar = s[end];

                while (charSet[currentChar])
                {
                    charSet[s[start]] = false;
                    start++;
                }

                charSet[currentChar] = true;

                int currentLenght = end - start + 1;
                maxLength = Math.Max(maxLength, currentLenght);
            }

            return maxLength;
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "abcabcbb";
            int result = solution.LengthOfLongestSubstring(s);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: s = "abcabcbb"
    Output: 3
    Explanation: The answer is "abc", with the length of 3.

 * Example 2:
    Input: s = "bbbbb"
    Output: 1
    Explanation: The answer is "b", with the length of 1.

 * Example 3:
    Input: s = "pwwkew"
    Output: 3
    Explanation: The answer is "wke", with the length of 3.
    Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 */