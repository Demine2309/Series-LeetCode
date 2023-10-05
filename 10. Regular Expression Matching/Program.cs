namespace SeriesLeetCode
{
    public class Solution
    {
        public bool IsMatch(string s, string p)
        {
            int m = s.Length;
            int n = p.Length;

            // Create a matrix to store matching results
            bool[,] dp = new bool[m + 1, n + 1];

            // An empty string matches an empty pattern
            dp[0, 0] = true;

            // Fill the first row of the matrix
            for (int j = 1; j <= n; j++)
            {
                if (p[j - 1] == '*')
                    // If the current character in the pattern is '*',
                    // We can skip it and its preceding character.
                    dp[0, j] = dp[0, j - 2];
            }

            // Fill the matrix
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (s[i - 1] == p[j - 1] || p[j - 1] == '.')
                        // If the current characters match or if the pattern has a '.', they match.
                        dp[i, j] = dp[i - 1, j - 1];
                    else if (p[j - 1] == '*')
                        // If the current character in the pattern is '*'
                        // 1. We can choose to skip the preceding character (0 occurrences of it), so dp[i, j] depends on dp[i, j - 2]
                        // 2. We can choose to use the preceding character (1 or more occurrences of it), so dp[i, j] depends on dp[i - 1, j]
                        //    Additionally, if the preceding character matches the current character in the input string or if the precedingg character
                        //    in the pattern is '.', then dp[i, j] is also true.
                        dp[i, j] = dp[i, j - 2] || (dp[i - 1, j] && (s[i - 1] == p[j - 2] || p[j - 2] == '.'));
                }
            }

            // The final result is stored in dp[m, n], which represents whether the entire input string matches the entire pattern.
            return dp[m, n];
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "aa";
            string p = "a.";

            bool result = solution.IsMatch(s, p);

            Console.WriteLine(result);
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