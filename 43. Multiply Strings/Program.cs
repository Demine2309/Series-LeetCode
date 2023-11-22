using System.Text;

namespace SeriesLeetCode
{
    public class Solution
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0")
                return "0";


            int[] result = new int[num1.Length + num2.Length];

            for (int i = num1.Length - 1; i >= 0; i--)
            {
                for (int j = num2.Length - 1; j >= 0; j--)
                {
                    int digit1 = num1[i] - '0';
                    int digit2 = num2[j] - '0';
                    int product = digit1 * digit2;

                    int pos1 = i + j;
                    int pos2 = i + j + 1;
                    int total = result[pos2] + product;

                    result[pos2] = total % 10;
                    result[pos1] += total / 10;
                }
            }

            int start = 0;
            while (start < result.Length && result[start] == 0)
                start++;

            StringBuilder sb = new StringBuilder();
            for (int i = start; i < result.Length; i++)
                sb.Append(result[i]);

            return sb.ToString();

        }
    }

    class MainClass 
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string num1 = "123";
            string num2 = "456";

            string result = solution.Multiply(num1, num2);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: num1 = "2", num2 = "3"
    Output: "6"

 * Example 2:
    Input: num1 = "123", num2 = "456"
    Output: "56088"
 */