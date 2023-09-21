namespace SeriesLeetCode
{
    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if(n <=2) return n;

            int[] dp = new int[n + 1];

            dp[1] = 1; dp[2] = 2;

            for(int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int n = 5;
            int result = solution.ClimbStairs(n);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: n = 2
    Output: 2
    Explanation: There are two ways to climb to the top.
    1. 1 step + 1 step
    2. 2 steps

 * Example 2:
    Input: n = 3
    Output: 3
    Explanation: There are three ways to climb to the top.
    1. 1 step + 1 step + 1 step
    2. 1 step + 2 steps
    3. 2 steps + 1 step
*/