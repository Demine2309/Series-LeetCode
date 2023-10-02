namespace SeriesLeetCode
{
    public class Solution
    {
        public int Reverse(int x)
        {
            int result = 0;

            while (x != 0)
            {
                int temp = x % 10;

                if (result > int.MaxValue / 10)
                    return 0;
                if (result < int.MinValue / 10)
                    return 0;

                result = result * 10 + temp;
                x /= 10;
            }

            return result;
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int x = 1534236469;
            int result = solution.Reverse(x);
            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: x = 123
    Output: 321

 * Example 2:
    Input: x = -123
    Output: -321

 * Example 3:
    Input: x = 120
    Output: 21
 */
