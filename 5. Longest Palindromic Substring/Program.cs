namespace SeriesLeetCode
{
    public class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return "";

            int start = 0;
            int maxLength = 1;

            // Create a boolean table to store whether a substring is a palindrome

            bool[,] isPalindrome = new bool[s.Length, s.Length];

            // All substrings of length 1 are palindromes
            for(int i = 0; i < s.Length; i++)
                isPalindrome[i , i] = true;

            // Check for palindromes of length 2
            for (int i =  0; i < s.Length - 1; i++)
            {
                if (s[i] == s[i + 1])
                {
                    isPalindrome[i , i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }

            // Check for palindromes of length 3 or more
            for (int length = 3; length <= s.Length; length++)
            {
                for (int i = 0; i < s.Length - length + 1; i++)
                {
                    int j = i + length - 1;  // Ending index of the current substring

                    if (s[i] == s[j] && isPalindrome[i + 1, j - 1])
                    {
                        isPalindrome[i, j] = true;

                        if (length > maxLength)
                        {
                            start = i;
                            maxLength = length;
                        }
                    }
                }
            }

            return s.Substring(start, maxLength);
        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            string s = "babad";
            
            string result = solution.LongestPalindrome(s);

            Console.WriteLine(result);
        }
    }
}

/*
 * Example 1:
    Input: s = "babad"
    Output: "bab"
    Explanation: "aba" is also a valid answer.

 * Example 2:
    Input: s = "cbbd"
    Output: "bb"
 */