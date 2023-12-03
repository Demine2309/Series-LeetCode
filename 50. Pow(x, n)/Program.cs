namespace SeriesLeetCode
{
    public class Solution
    {
        public double MyPow(double x, int n)
        {
            #region Stack overflow issue
            // recursive approach
            //if (n == 0)
            //    return 1;

            //if (n > 0)
            //    return x * MyPow(x, n - 1);
            //else
            //    return 1 / (x * MyPow(x, -(n + 1)));

            // Sequential approach
            //double result = 1;

            //for (int i = 0; i < n; i++)
            //{
            //    result *= x;
            //}

            //return result;
            #endregion

            if (n == 0)
                return 1;

            double half = MyPow(x, n / 2);

            if (n % 2 == 0)
                return half * half;
            else if (n > 0)
                return x * half * half;
            else // n < 0
                return (1 / x) * half * half;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            double x = 0.00001;
            int n = 2147483647;

            double result = Math.Round(solution.MyPow(x, n), 5);
            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: x = 2.00000, n = 10
    Output: 1024.00000

 * Example 2:
    Input: x = 2.10000, n = 3
    Output: 9.26100

 * Example 3:
    Input: x = 2.00000, n = -2
    Output: 0.25000
    Explanation: 2^-2 = 1/2^2 = 1/4 = 0.25
 */