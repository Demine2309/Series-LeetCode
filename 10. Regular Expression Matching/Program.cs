namespace SeriesLeetCode
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {

        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution(); 


        }
    }
}

/*
 * Example 1:
    Input: s = "aa", p = "a"
    Output: false
    Explanation: "a" does not match the entire string "aa".

 * Example 2:
    Input: s = "aa", p = "a*"
    Output: true
    Explanation: '*' means zero or more of the preceding element, 'a'. Therefore, by repeating 'a' once, it becomes "aa".

 * Example 3:
    Input: s = "ab", p = ".*"
    Output: true
    Explanation: ".*" means "zero or more (*) of any character (.)".
 */