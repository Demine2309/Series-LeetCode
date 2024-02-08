using System;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0) return "";

        string shortest = strs[0];
        foreach(string str in strs)
        {
            if (str.Length < shortest.Length)
            {
                shortest = str;
            }
        }

        for(int i = 0; i < shortest.Length; i++)
        {
            char currentChar = shortest[i];

            foreach(string str in strs)
            {
                if (str[i] != currentChar)
                {
                    shortest = shortest.Substring(0, i);
                    break;
                }
            }
        }

        return shortest;
    }
}

class MainClass
{
    static void Main()
    {
        Solution solution = new Solution();

        string[] strs = { "flower", "flow", "flight" };

        string result = solution.LongestCommonPrefix(strs);

        Console.WriteLine(result);
    }
}
