namespace SeriesLeetCode
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            int n = digits.Length;
            int carry = 1;  

            for (int i = n - 1; i >= 0; i--)
            {
                int total = digits[i] + carry;

                if (total == 10)
                {
                    digits[i] = 0;
                    carry = 1;
                }
                else
                {
                    digits[i] = total;
                    carry = 0;
                }
            }

            if (carry == 1)
            {
                int[] result = new int[n + 1];
                result[0] = 1;
                Array.Copy(digits, 0, result, 1, n);
                return result;
            }

            return digits;
        }


    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] digits = { 7, 2, 8, 5, 0, 9, 1, 2, 9, 5, 3, 6, 6, 7, 3, 2, 8, 4, 3, 7, 9, 5, 7, 7, 4, 7, 4, 9, 4, 7, 0, 1, 1, 1, 7, 4, 0, 0, 9};
            int[] result = solution.PlusOne(digits);

            foreach (int i in result)
            {
                Console.Write(i + " ");
            }
        }
    }
}

/*
 * Example 1:
    Input: digits = [1,2,3]
    Output: [1,2,4]
    Explanation: The array represents the integer 123.
    Incrementing by one gives 123 + 1 = 124.
    Thus, the result should be [1,2,4].

 * Example 2:
    Input: digits = [4,3,2,1]
    Output: [4,3,2,2]
    Explanation: The array represents the integer 4321.
    Incrementing by one gives 4321 + 1 = 4322.
    Thus, the result should be [4,3,2,2].

 * Example 3:
    Input: digits = [9]
    Output: [1,0]
    Explanation: The array represents the integer 9.
    Incrementing by one gives 9 + 1 = 10.
    Thus, the result should be [1,0].
 */