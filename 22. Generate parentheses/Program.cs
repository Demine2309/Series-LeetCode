namespace SeriesLeetCode
{
    public class Solution
    {
        public IList<string> GenerateParentheses(int n)
        {
            IList<string> result = new List<string>();

            GenerateParenthesesRecursive(result, "", n, n);
            
            return result;
        }

        private void GenerateParenthesesRecursive(IList<string> result, string current, int openRemaining, int closeRemaining)
        {
            if (openRemaining == 0 && closeRemaining == 0)
            {
                result.Add(current);
                return;
            }

            if (openRemaining > 0)
            {
                GenerateParenthesesRecursive(result, current + "(", openRemaining - 1, closeRemaining);
            }

            if (closeRemaining > openRemaining)
            {
                GenerateParenthesesRecursive(result, current + ")", openRemaining, closeRemaining - 1);
            }
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int n = 4;
            IList<string> result = solution.GenerateParentheses(n);

            foreach(string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}

/*
 * Example 1:
    Input: n = 3
    Output: ["((()))","(()())","(())()","()(())","()()()"]

 * Example 2:
    Input: n = 1
    Output: ["()"]
*/