namespace SeriesLeetCode
{
    public class Solution
    {
        public string CountAndSay(int n)
        {
            if (n == 1)
            {
                return "1";
            }

            string previous = CountAndSay(n - 1);
            StringBuilder result = new StringBuilder();

            int count = 1;
            for (int i = 0; i < previous.Length; i++)
            {
                if (i + 1 < previous.Length && previous[i] == previous[i + 1])
                {
                    count++;
                }
                else
                {
                    result.Append(count);
                    result.Append(previous[i]);
                    count = 1;
                }
            }

            return result.ToString();
        }

        class MainClass
        {
            static void Main(string[] args)
            {
                Solution solution = new Solution();

                int n = 9;
                string s = solution.CountAndSay(n);

                Console.WriteLine(s);
            }
        }
    }
}

/*
 * Example 1:
    Input: n = 1
    Output: "1"
    Explanation: This is the base case.

 * Example 2:
    Input: n = 4
    Output: "1211"
    Explanation:
    countAndSay(1) = "1"
    countAndSay(2) = say "1" = one 1 = "11"
    countAndSay(3) = say "11" = two 1's = "21"
    countAndSay(4) = say "21" = one 2 + one 1 = "12" + "11" = "1211"
 */