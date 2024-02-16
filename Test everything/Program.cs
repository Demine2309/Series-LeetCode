using System;

public class Solution
{
    public bool IsValid(string s)
    {
        
    }
}

class MainClass
{
    static void Main()
    {
        Solution solution = new Solution();

        string s = "({{}})[]";

        bool result = solution.IsValid(s);

        Console.WriteLine(result);
    }
}
