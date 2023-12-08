namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<string> FizzBuzz(int n)
        {
            IList<string> result = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                bool divisibleBy3 = i % 3 == 0;
                bool divisibleBy5 = i % 5 == 0;

                if (divisibleBy3 && divisibleBy5)
                    result.Add("FizzBuzz");
                else if (divisibleBy3 && !divisibleBy5)
                    result.Add("Fizz");
                else if (!divisibleBy3 && divisibleBy5)
                    result.Add("Buzz");
                else
                    result.Add(i.ToString());
            }

            return result;
        }

        public void PrintList(IList<string> result)
        {
            foreach (var i in result)
                Console.Write(i + " ");
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int n = 15;
            IList<string> result = solution.FizzBuzz(n);

            solution.PrintList(result);
        }
    }
}

/*
 * Example 1:
    Input: n = 3
    Output: ["1","2","Fizz"]

 * Example 2:
    Input: n = 5
    Output: ["1","2","Fizz","4","Buzz"]

 * Example 3:
    Input: n = 15
    Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
 */