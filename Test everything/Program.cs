class Program
{
    static void Main(string[] args)
    {
        string s = "(())";

        bool result = IsValid(s);

        Console.WriteLine(result);
    }

    private static bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in s)
        {
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char openingBracket = stack.Pop();
                if (openingBracket != '(')
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}