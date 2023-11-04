namespace SeriesLeetCode
{
    public class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            int quotient = 0;

            if (dividend == Int32.MinValue && divisor == -1)
            {
                return Int32.MaxValue;
            }

            long aDividend = Math.Abs((long)dividend);
            long aDivisor = Math.Abs((long)divisor);

            while (aDividend >= aDivisor)
            {
                // Another ways (bester for runtime, but use more memory than way below)
                //long temp = aDivisor;
                //long multiple = 1;

                //while (aDividend >= (temp << 1))
                //{
                //    temp <<= 1;
                //    multiple <<= 1;
                //}
                //aDividend -= temp;
                // quotient += (int)multiple;

                quotient ++;
                aDividend -= aDivisor;
            }

            if ((dividend < 0 && divisor > 0) || (dividend > 0 && divisor < 0))
                quotient *= -1;

            return quotient;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int dividend = -2147483648;
            int divisor = -1;

            int quotient = solution.Divide(dividend,divisor);

            Console.WriteLine(quotient);
        }
    }
}

/*
 * Example 1:
    Input: dividend = 10, divisor = 3
    Output: 3
    Explanation: 10/3 = 3.33333.. which is truncated to 3.

 * Example 2:
    Input: dividend = 7, divisor = -3
    Output: -2
    Explanation: 7/-3 = -2.33333.. which is truncated to -2.
 */