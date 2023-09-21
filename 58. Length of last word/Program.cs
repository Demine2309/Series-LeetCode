namespace SeriesLeetCode
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            int count = 0;
            s = s.Trim();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (s[i] != ' ')
                {
                    count++;
                }
                if (s[i] == ' ')
                {
                    return count;
                }
            }
            return count;
        }
    }

    public class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "   fly me   to   the moon  ";

            int result = solution.LengthOfLastWord(s);
            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: s = "Hello World"
    Output: 5
    Explanation: The last word is "World" with length 5.

 * Example 2:
    Input: s = "   fly me   to   the moon  "
    Output: 4
    Explanation: The last word is "moon" with length 4.

 * Example 3:
    Input: s = "luffy is still joyboy"
    Output: 6
    Explanation: The last word is "joyboy" with length 6.
 */