using System.Text;

namespace SeriesLeetCode
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            int carry = 0;

            int maxLength = Math.Max(a.Length, b.Length);

            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int bitA = a[i] - '0';
                int bitB = b[i] - '0';

                int total = bitA + bitB + carry;
                carry = total / 2;
                int bitSum = total % 2;

                result.Insert(0, bitSum);
            }

            if (carry > 0)
            {
                result.Insert(0, carry);
            }

            return result.ToString();
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string a = "11";
            string b = "1";
            string result = solution.AddBinary(a, b);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: a = "11", b = "1"
    Output: "100"

 * Example 2:
    Input: a = "1010", b = "1011"
    Output: "10101"
 */