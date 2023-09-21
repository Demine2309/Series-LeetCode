namespace SeriesLeetCode
{
    public class Solution
    {
        public int MySqrt(int x)
        {
            int result = 0;

            if (x == 0)
            {
                return result;
            }
            else if (x == 1)
            {
                result = 1;
            }
            else
            {
                for (int i = 1; i < x; i++)
                {
                    if (x >= Math.Pow(i, 2) && x < Math.Pow(i + 1, 2))
                    {
                        result = i;
                        break;
                    }
                }
            }

            return result;
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int x = 2147395600;
            int result = solution.MySqrt(x);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: x = 4
    Output: 2
    Explanation: The square root of 4 is 2, so we return 2.

 * Example 2:
    Input: x = 8
    Output: 2
    Explanation: The square root of 8 is 2.82842..., and since we round it down to the nearest integer, 2 is returned.
 */