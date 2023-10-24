namespace SeriesLeetCode
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false; 
                    }

                    char openingBracket = stack.Pop();
                    if (!AreBracketsMatching(openingBracket, c))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0; 
        }

        private bool AreBracketsMatching(char opening, char closing)
        {
            return (opening == '(' && closing == ')') ||
                   (opening == '[' && closing == ']') ||
                   (opening == '{' && closing == '}');
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "(){}({)";

            bool result = solution.IsValid(s);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: s = "()"
    Output: true

 * Example 2:
    Input: s = "()[]{}"
    Output: true
 
 * Example 3:
    Input: s = "(]"
    Output: false
*/