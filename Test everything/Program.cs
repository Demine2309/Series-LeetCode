using System;

public class Solution
{
    public int LLL(string s)
    {
        int maxLength = 0;

        for(int i = 0; i < s.Length; i++)
        {
            char currentChar = s[i];
            bool[] checkerViet = new bool[s.Length - i - 1];
            int k = 0;

            for(int j = i + 1; j < s.Length; j++)
            {
                if (currentChar == s[j])
                {
                    checkerViet[k] = true;
                    break;
                }
                else
                {
                    checkerViet[k] = false;
                }
                k++;
            }

            if(k + 1> maxLength)
            {
                maxLength = k + 1;
            }
        }

        return maxLength;
    }
}

class MainClass
{
    static void Main()
    {
        Solution solution = new Solution();

        string s = "abcabcbb";

        int result = solution.LLL(s);

        Console.WriteLine(result);
    }
}
